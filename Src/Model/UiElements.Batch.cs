using System;
using System.Collections.Generic;
using System.Linq;

namespace RiftAssistant.Model;

internal partial class UiElements
{
	private void RefreshRootElements()
	{
		if (!Core.Settings.BatchedMemoryReads) {
			foreach (var element in rootElements.Values) {
				element.Refresh();
			}

			return;
		}

		ResolveBatch([.. rootElements.Values]);
	}

	private void RefreshConditionalElements()
	{
		if (!Core.Settings.BatchedMemoryReads) {
			foreach (var element in conditionalElements.Values) {
				RefreshConditional(element);
			}

			return;
		}

		// Sequential refreshing lets an element see the state its dependencies got earlier in the same pass,
		// so elements are grouped into waves in which no element depends on another one of the same wave.
		var wave = new List<UiElement>();
		var members = new HashSet<UiElement>();
		foreach (var element in conditionalElements.Values) {
			if (DependsOnAny(element, members)) {
				ResolveWave(wave);
				wave.Clear();
				members.Clear();
			}

			wave.Add(element);
			members.Add(element);
		}

		ResolveWave(wave);
	}

	private static bool DependsOnAny(UiElement element, HashSet<UiElement> candidates)
	{
		if (candidates.Count == 0) return false;

		return Depends(element.uiElement0, candidates) || Depends(element.uiElement1, candidates);
	}

	private static bool Depends(UiElement dependency, HashSet<UiElement> candidates)
	{
		return dependency != null && (candidates.Contains(dependency) || (dependency.ReplacementWhenNotVisible != null && candidates.Contains(dependency.ReplacementWhenNotVisible)));
	}

	private void ResolveWave(List<UiElement> wave)
	{
		var eligible = new List<UiElement>(wave.Count);
		foreach (var element in wave) {
			if (!IsVisible(element.uiElement0) || !IsVisible(element.uiElement1)) {
				Hide(element);
			} else {
				eligible.Add(element);
			}
		}

		ResolveBatch(eligible);
	}

	private void ResolveBatch(List<UiElement> elements)
	{
		if (elements.Count == 0 || bucketCount <= 0 || uiHash <= 0) return;

		var current = new long[elements.Count];
		var depth = new int[elements.Count];
		var active = new List<int>(elements.Count);
		for (int i = 0; i < elements.Count; i++) {
			var element = elements[i];
			if ((uint)element.Bucket >= bucketCount) element.Bucket = ComputeBucket(element.hash, uiHash);
			if ((uint)element.Bucket >= bucketCount) continue;

			current[i] = buckets[element.Bucket];
			active.Add(i);
		}

		while (active.Count > 0) {
			active.RemoveAll(i => {
				if (current[i] != 0 && depth[i]++ < MaxChainDepth) return false;

				Hide(elements[i]);
				return true;
			});
			if (active.Count == 0) break;

			var nodeAddresses = new long[active.Count];
			for (int k = 0; k < active.Count; k++) {
				nodeAddresses[k] = current[active[k]];
			}

			var nodes = new HashNode[active.Count];
			GameWindowManager.ReadMany(nodeAddresses, nodes);

			var matches = new List<int>();
			for (int k = 0; k < active.Count; k++) {
				var element = elements[active[k]];
				if (nodes[k].Key != element.hashPath) continue;

				element.long_0 = nodes[k].Value;
				matches.Add(k);
			}

			var resolved = new HashSet<int>();
			if (matches.Count > 0) {
				var dataAddresses = new long[matches.Count];
				for (int m = 0; m < matches.Count; m++) {
					dataAddresses[m] = elements[active[matches[m]]].long_0;
				}

				var data = new UiElementData[matches.Count];
				GameWindowManager.ReadMany(dataAddresses, data);
				for (int m = 0; m < matches.Count; m++) {
					var element = elements[active[matches[m]]];
					element.Class75_0 = data[m];
					if (element.Class75_0.Id != element.hashPath) continue;

					ApplyResolved(element);
					resolved.Add(active[matches[m]]);
				}
			}

			for (int k = 0; k < active.Count; k++) {
				current[active[k]] = nodes[k].Next;
			}

			active.RemoveAll(resolved.Contains);
		}

		if (Core.Settings.VerifyBatchedReads) VerifyAgainstSequential(elements);
	}

	private void VerifyAgainstSequential(List<UiElement> elements)
	{
		foreach (var element in elements) {
			var batched = (element.long_0, element.Visible, element.bool_0, element.rectangle, element.Bucket);
			Resolve(element);
			var sequential = (element.long_0, element.Visible, element.bool_0, element.rectangle, element.Bucket);
			if (!batched.Equals(sequential)) Logger.Info($"batched UI read mismatch for {element.Path}: batched {batched}, sequential {sequential}");
		}
	}
}