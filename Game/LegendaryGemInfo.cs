using System.Collections.Generic;
using Plugins;

namespace work;

internal class LegendaryGemInfo : ILegendaryGemInfo
{
	private readonly Player p;

	public IBuff BaneOfThePowerfulPrimary => p.Powers.GetBuff(383014u);

	public IBuff BaneOfThePowerfulSecondary => p.Powers.GetBuff(451157u);

	public IBuff BaneOfTheStrickenPrimary => p.Powers.GetBuff(428348u);

	public IBuff BaneOfTheStrickenSecondary => p.Powers.GetBuff(428349u);

	public IBuff BaneOfTheTrappedPrimary => p.Powers.GetBuff(403456u);

	public IBuff BaneOfTheTrappedSecondary => p.Powers.GetBuff(403457u);

	public IBuff BoonOfTheHoarderPrimary => p.Powers.GetBuff(403470u);

	public IBuff BoonOfTheHoarderSecondary => p.Powers.GetBuff(403784u);

	public IBuff BoyarskysChipPrimary => p.Powers.GetBuff(428352u);

	public IBuff BoyarskysChipSecondary => p.Powers.GetBuff(428353u);

	public IBuff EnforcerPrimary => p.Powers.GetBuff(403466u);

	public IBuff EnforcerSecondary => p.Powers.GetBuff(403472u);

	public IBuff EsotericAlterationPrimary => p.Powers.GetBuff(428029u);

	public IBuff EsotericAlterationSecondary => p.Powers.GetBuff(428030u);

	public IBuff GemOfEasePrimary => p.Powers.GetBuff(403459u);

	public IBuff GemOfEaseSecondary => p.Powers.GetBuff(428691u);

	public IBuff GemOfEfficaciousToxinPrimary => p.Powers.GetBuff(403461u);

	public IBuff GemOfEfficaciousToxinSecondary => p.Powers.GetBuff(403556u);

	public IBuff GogokOfSwiftnessPrimary => p.Powers.GetBuff(403464u);

	public IBuff GogokOfSwiftnessSecondary => p.Powers.GetBuff(403524u);

	public IBuff IceblinkPrimary => p.Powers.GetBuff(428354u);

	public IBuff IceblinkSecondary => p.Powers.GetBuff(428356u);

	public IBuff InvigoratingGemstonePrimary => p.Powers.GetBuff(403465u);

	public IBuff InvigoratingGemstoneSecondary => p.Powers.GetBuff(403624u);

	public IBuff LegacyOfDreamsPrimary => p.Powers.GetBuff(483319u);

	public IBuff LegacyOfDreamsSecondary => p.Powers.GetBuff(483320u);

	public IBuff MirinaeTeardropOfTheStarweaverPrimary => p.Powers.GetBuff(403463u);

	public IBuff MirinaeTeardropOfTheStarweaverSecondary => p.Powers.GetBuff(403620u);

	public IBuff MoltenWildebeestsGizzardPrimary => p.Powers.GetBuff(428031u);

	public IBuff MoltenWildebeestsGizzardSecondary => p.Powers.GetBuff(428032u);

	public IBuff MoratoriumPrimary => p.Powers.GetBuff(403467u);

	public IBuff MoratoriumSecondary => p.Powers.GetBuff(403687u);

	public IBuff MutilationGuardPrimary => p.Powers.GetBuff(428350u);

	public IBuff MutilationGuardSecondary => p.Powers.GetBuff(428351u);

	public IBuff PainEnhancerPrimary => p.Powers.GetBuff(403462u);

	public IBuff PainEnhancerSecondary => p.Powers.GetBuff(403600u);

	public IBuff RedSoulShardPrimary => p.Powers.GetBuff(454736u);

	public IBuff RedSoulShardSecondary => p.Powers.GetBuff(454737u);

	public IBuff SimplicitysStrengthPrimary => p.Powers.GetBuff(403469u);

	public IBuff SimplicitysStrengthSecondary => p.Powers.GetBuff(403473u);

	public IBuff TaegukPrimary => p.Powers.GetBuff(403471u);

	public IBuff TaegukSecondary => p.Powers.GetBuff(403785u);

	public IBuff WreathOfLightningPrimary => p.Powers.GetBuff(403460u);

	public IBuff WreathOfLightningSecondary => p.Powers.GetBuff(403560u);

	public IBuff ZeisStoneOfVengeancePrimary => p.Powers.GetBuff(403468u);

	public IBuff ZeisStoneOfVengeanceSecondary => p.Powers.GetBuff(403727u);

	public IBuff WhisperOfAtonementPrimary => p.Powers.GetBuff(486910u);

	public IBuff WhisperOfAtonementSecondary => p.Powers.GetBuff(486910u);

	internal LegendaryGemInfo(Player playerContext)
	{
		p = playerContext;
	}

	public IEnumerable<IBuff> AllBuffs()
	{
		IBuff buff;
		if ((buff = p.Powers.GetBuff(383014u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(451157u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428348u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428349u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403456u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403457u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403470u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403784u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428352u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428353u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403466u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403472u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428029u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428030u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403459u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428691u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403461u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403556u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403464u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403524u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428354u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428356u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403465u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403624u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(483319u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(483320u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403463u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403620u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428031u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428032u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403467u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403687u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428350u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(428351u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403462u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403600u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(454736u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(454737u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403469u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403473u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403471u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403785u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(486910u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(486910u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403460u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403560u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403468u)) != null)
		{
			yield return buff;
		}
		if ((buff = p.Powers.GetBuff(403727u)) != null)
		{
			yield return buff;
		}
	}
}
