using System.Collections.Generic;

namespace Plugins;

public interface ILegendaryGemInfo
{
	IBuff BaneOfThePowerfulPrimary { get; }

	IBuff BaneOfThePowerfulSecondary { get; }

	IBuff BaneOfTheStrickenPrimary { get; }

	IBuff BaneOfTheStrickenSecondary { get; }

	IBuff BaneOfTheTrappedPrimary { get; }

	IBuff BaneOfTheTrappedSecondary { get; }

	IBuff BoonOfTheHoarderPrimary { get; }

	IBuff BoonOfTheHoarderSecondary { get; }

	IBuff BoyarskysChipPrimary { get; }

	IBuff BoyarskysChipSecondary { get; }

	IBuff EnforcerPrimary { get; }

	IBuff EnforcerSecondary { get; }

	IBuff EsotericAlterationPrimary { get; }

	IBuff EsotericAlterationSecondary { get; }

	IBuff GemOfEasePrimary { get; }

	IBuff GemOfEaseSecondary { get; }

	IBuff GemOfEfficaciousToxinPrimary { get; }

	IBuff GemOfEfficaciousToxinSecondary { get; }

	IBuff GogokOfSwiftnessPrimary { get; }

	IBuff GogokOfSwiftnessSecondary { get; }

	IBuff IceblinkPrimary { get; }

	IBuff IceblinkSecondary { get; }

	IBuff InvigoratingGemstonePrimary { get; }

	IBuff InvigoratingGemstoneSecondary { get; }

	IBuff LegacyOfDreamsPrimary { get; }

	IBuff LegacyOfDreamsSecondary { get; }

	IBuff MirinaeTeardropOfTheStarweaverPrimary { get; }

	IBuff MirinaeTeardropOfTheStarweaverSecondary { get; }

	IBuff MoltenWildebeestsGizzardPrimary { get; }

	IBuff MoltenWildebeestsGizzardSecondary { get; }

	IBuff MoratoriumPrimary { get; }

	IBuff MoratoriumSecondary { get; }

	IBuff MutilationGuardPrimary { get; }

	IBuff MutilationGuardSecondary { get; }

	IBuff PainEnhancerPrimary { get; }

	IBuff PainEnhancerSecondary { get; }

	IBuff RedSoulShardPrimary { get; }

	IBuff RedSoulShardSecondary { get; }

	IBuff SimplicitysStrengthPrimary { get; }

	IBuff SimplicitysStrengthSecondary { get; }

	IBuff TaegukPrimary { get; }

	IBuff TaegukSecondary { get; }

	IBuff WhisperOfAtonementPrimary { get; }

	IBuff WhisperOfAtonementSecondary { get; }

	IBuff WreathOfLightningPrimary { get; }

	IBuff WreathOfLightningSecondary { get; }

	IBuff ZeisStoneOfVengeancePrimary { get; }

	IBuff ZeisStoneOfVengeanceSecondary { get; }

	IEnumerable<IBuff> AllBuffs();
}
