using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_Farming
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> DateType { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> TotalOutputValueCP { get; set; }
		public Nullable<decimal> AgricultureCP { get; set; }
		public Nullable<decimal> ForestryCP { get; set; }
		public Nullable<decimal> AnimalHusbandryCP { get; set; }
		public Nullable<decimal> FisheryCP { get; set; }
		public Nullable<decimal> TotalOutputValueGYoYCP { get; set; }
		public Nullable<decimal> AgricultureGYoYCP { get; set; }
		public Nullable<decimal> ForestryGYoYCP { get; set; }
		public Nullable<decimal> AnimalHusbandryGYoYCP { get; set; }
		public Nullable<decimal> FisheryGYoYCP { get; set; }
		public Nullable<decimal> TotalOutputValueY90P { get; set; }
		public Nullable<decimal> AgricultureY90P { get; set; }
		public Nullable<decimal> ForestryY90P { get; set; }
		public Nullable<decimal> AnimalHusbandryY90P { get; set; }
		public Nullable<decimal> FisheryY90P { get; set; }
		public Nullable<decimal> TotalOutputValueGYoYY90P { get; set; }
		public Nullable<decimal> AgricultureGYoYY90P { get; set; }
		public Nullable<decimal> ForestryGYoYY90P { get; set; }
		public Nullable<decimal> AnimalHusbandryGYoYY90P { get; set; }
		public Nullable<decimal> FisheryGYoYY90P { get; set; }
		public Nullable<decimal> TotalOutputValueIndex { get; set; }
		public Nullable<decimal> AgricultureIndex { get; set; }
		public Nullable<decimal> ForestryIndex { get; set; }
		public Nullable<decimal> AnimalHusbandryIndex { get; set; }
		public Nullable<decimal> FisheryIndex { get; set; }
		public Nullable<decimal> TotalPowerOfAgrMachinery { get; set; }
		public Nullable<decimal> MediumLargeTractorsNum { get; set; }
		public Nullable<decimal> MediumLargeTractorsPower { get; set; }
		public Nullable<decimal> SmallTractorsNum { get; set; }
		public Nullable<decimal> SmallTractorsPower { get; set; }
		public Nullable<decimal> MLTractorDrivenImplements { get; set; }
		public Nullable<decimal> STractorDrivenImplements { get; set; }
		public Nullable<decimal> RuralDieselEngineeIDNum { get; set; }
		public Nullable<decimal> RuralDieselEngineeIDPower { get; set; }
		public Nullable<decimal> RuralLoadingAutoNum { get; set; }
		public Nullable<decimal> RuralLoadingAutoPower { get; set; }
		public Nullable<decimal> FishingPowerboatNum { get; set; }
		public Nullable<decimal> FishingPowerboatPower { get; set; }
		public Nullable<decimal> EffectiveIrrigationArea { get; set; }
		public Nullable<decimal> TotalFertilizerUsage { get; set; }
		public Nullable<decimal> NitroFertilizerUsage { get; set; }
		public Nullable<decimal> PotashFertilierUsage { get; set; }
		public Nullable<decimal> PhosphateFertilizerUsage { get; set; }
		public Nullable<decimal> CompositeFertilizerUsage { get; set; }
		public Nullable<decimal> ElectricityGeneratorNum { get; set; }
		public Nullable<decimal> ElectricityGeneratorPower { get; set; }
		public Nullable<decimal> ElectricityConsumption { get; set; }
		public Nullable<decimal> RuralFarmingWorkers { get; set; }
		public Nullable<decimal> RuralWorkersIndustrial { get; set; }
		public Nullable<decimal> RuralWorkersConstruction { get; set; }
		public Nullable<decimal> RuralWorkersTWPT { get; set; }
		public Nullable<decimal> RuralWorkersWRFB { get; set; }
		public Nullable<decimal> RuralWorkersOtherNonAgri { get; set; }
		public Nullable<decimal> FAInvOnForestry { get; set; }
		public Nullable<decimal> FAInvOperatingForestry { get; set; }
		public Nullable<decimal> BasicConstructionInvOF { get; set; }
		public Nullable<decimal> UpgradeInnovationInvOF { get; set; }
		public Nullable<decimal> FAInvForestProject { get; set; }
		public Nullable<decimal> FAInvFP { get; set; }
		public Nullable<decimal> BasicConstrctionInvFP { get; set; }
		public Nullable<decimal> UpgradeInnovationInvFP { get; set; }
		public Nullable<decimal> CalamityStrickenArea { get; set; }
		public Nullable<decimal> FloodStrickenArea { get; set; }
		public Nullable<decimal> DroughtStrickenArea { get; set; }
		public Nullable<decimal> CalamityInfestedArea { get; set; }
		public Nullable<decimal> FloodInfestedArea { get; set; }
		public Nullable<decimal> DroughtInfestedArea { get; set; }
		public Nullable<decimal> EffectiveIrrigatedArea { get; set; }
		public Nullable<decimal> WaterReserveIA { get; set; }
		public Nullable<decimal> FloodProtectedArea { get; set; }
		public Nullable<decimal> WaterSoilLossProtectedArea { get; set; }
		public Nullable<decimal> AlkaliControlledArea { get; set; }
		public Nullable<decimal> DikeLength { get; set; }
		public Nullable<decimal> DikeProtectedArea { get; set; }
		public Nullable<decimal> ActualArableLandAreaYE { get; set; }
		public Nullable<decimal> ReducedArableLandArea { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

