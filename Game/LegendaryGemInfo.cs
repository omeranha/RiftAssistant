using System.Collections.Generic;

public class LegendaryGemInfo
{
	private readonly Player p;

	public Buff BaneOfThePowerfulPrimary => p.Powers.GetBuff(383014u);

	public Buff BaneOfThePowerfulSecondary => p.Powers.GetBuff(451157u);

	public Buff BaneOfTheStrickenPrimary => p.Powers.GetBuff(428348u);

	public Buff BaneOfTheStrickenSecondary => p.Powers.GetBuff(428349u);

	public Buff BaneOfTheTrappedPrimary => p.Powers.GetBuff(403456u);

	public Buff BaneOfTheTrappedSecondary => p.Powers.GetBuff(403457u);

	public Buff BoonOfTheHoarderPrimary => p.Powers.GetBuff(403470u);

	public Buff BoonOfTheHoarderSecondary => p.Powers.GetBuff(403784u);

	public Buff BoyarskysChipPrimary => p.Powers.GetBuff(428352u);

	public Buff BoyarskysChipSecondary => p.Powers.GetBuff(428353u);

	public Buff EnforcerPrimary => p.Powers.GetBuff(403466u);

	public Buff EnforcerSecondary => p.Powers.GetBuff(403472u);

	public Buff EsotericAlterationPrimary => p.Powers.GetBuff(428029u);

	public Buff EsotericAlterationSecondary => p.Powers.GetBuff(428030u);

	public Buff GemOfEasePrimary => p.Powers.GetBuff(403459u);

	public Buff GemOfEaseSecondary => p.Powers.GetBuff(428691u);

	public Buff GemOfEfficaciousToxinPrimary => p.Powers.GetBuff(403461u);

	public Buff GemOfEfficaciousToxinSecondary => p.Powers.GetBuff(403556u);

	public Buff GogokOfSwiftnessPrimary => p.Powers.GetBuff(403464u);

	public Buff GogokOfSwiftnessSecondary => p.Powers.GetBuff(403524u);

	public Buff IceblinkPrimary => p.Powers.GetBuff(428354u);

	public Buff IceblinkSecondary => p.Powers.GetBuff(428356u);

	public Buff InvigoratingGemstonePrimary => p.Powers.GetBuff(403465u);

	public Buff InvigoratingGemstoneSecondary => p.Powers.GetBuff(403624u);

	public Buff LegacyOfDreamsPrimary => p.Powers.GetBuff(483319u);

	public Buff LegacyOfDreamsSecondary => p.Powers.GetBuff(483320u);

	public Buff MirinaeTeardropOfTheStarweaverPrimary => p.Powers.GetBuff(403463u);

	public Buff MirinaeTeardropOfTheStarweaverSecondary => p.Powers.GetBuff(403620u);

	public Buff MoltenWildebeestsGizzardPrimary => p.Powers.GetBuff(428031u);

	public Buff MoltenWildebeestsGizzardSecondary => p.Powers.GetBuff(428032u);

	public Buff MoratoriumPrimary => p.Powers.GetBuff(403467u);

	public Buff MoratoriumSecondary => p.Powers.GetBuff(403687u);

	public Buff MutilationGuardPrimary => p.Powers.GetBuff(428350u);

	public Buff MutilationGuardSecondary => p.Powers.GetBuff(428351u);

	public Buff PainEnhancerPrimary => p.Powers.GetBuff(403462u);

	public Buff PainEnhancerSecondary => p.Powers.GetBuff(403600u);

	public Buff RedSoulShardPrimary => p.Powers.GetBuff(454736u);

	public Buff RedSoulShardSecondary => p.Powers.GetBuff(454737u);

	public Buff SimplicitysStrengthPrimary => p.Powers.GetBuff(403469u);

	public Buff SimplicitysStrengthSecondary => p.Powers.GetBuff(403473u);

	public Buff TaegukPrimary => p.Powers.GetBuff(403471u);

	public Buff TaegukSecondary => p.Powers.GetBuff(403785u);

	public Buff WreathOfLightningPrimary => p.Powers.GetBuff(403460u);

	public Buff WreathOfLightningSecondary => p.Powers.GetBuff(403560u);

	public Buff ZeisStoneOfVengeancePrimary => p.Powers.GetBuff(403468u);

	public Buff ZeisStoneOfVengeanceSecondary => p.Powers.GetBuff(403727u);

	public Buff WhisperOfAtonementPrimary => p.Powers.GetBuff(486910u);

	public Buff WhisperOfAtonementSecondary => p.Powers.GetBuff(486910u);

	internal LegendaryGemInfo(Player playerContext)
	{
		p = playerContext;
	}

	public IEnumerable<Buff> AllBuffs()
	{
		Buff buff;
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
