using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_FarmingMap : EntityTypeConfiguration<ED_Farming>
	{
		public ED_FarmingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_Farming");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DateType).HasColumnName("DateType");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.TotalOutputValueCP).HasColumnName("TotalOutputValueCP");
			this.Property(t => t.AgricultureCP).HasColumnName("AgricultureCP");
			this.Property(t => t.ForestryCP).HasColumnName("ForestryCP");
			this.Property(t => t.AnimalHusbandryCP).HasColumnName("AnimalHusbandryCP");
			this.Property(t => t.FisheryCP).HasColumnName("FisheryCP");
			this.Property(t => t.TotalOutputValueGYoYCP).HasColumnName("TotalOutputValueGYoYCP");
			this.Property(t => t.AgricultureGYoYCP).HasColumnName("AgricultureGYoYCP");
			this.Property(t => t.ForestryGYoYCP).HasColumnName("ForestryGYoYCP");
			this.Property(t => t.AnimalHusbandryGYoYCP).HasColumnName("AnimalHusbandryGYoYCP");
			this.Property(t => t.FisheryGYoYCP).HasColumnName("FisheryGYoYCP");
			this.Property(t => t.TotalOutputValueY90P).HasColumnName("TotalOutputValueY90P");
			this.Property(t => t.AgricultureY90P).HasColumnName("AgricultureY90P");
			this.Property(t => t.ForestryY90P).HasColumnName("ForestryY90P");
			this.Property(t => t.AnimalHusbandryY90P).HasColumnName("AnimalHusbandryY90P");
			this.Property(t => t.FisheryY90P).HasColumnName("FisheryY90P");
			this.Property(t => t.TotalOutputValueGYoYY90P).HasColumnName("TotalOutputValueGYoYY90P");
			this.Property(t => t.AgricultureGYoYY90P).HasColumnName("AgricultureGYoYY90P");
			this.Property(t => t.ForestryGYoYY90P).HasColumnName("ForestryGYoYY90P");
			this.Property(t => t.AnimalHusbandryGYoYY90P).HasColumnName("AnimalHusbandryGYoYY90P");
			this.Property(t => t.FisheryGYoYY90P).HasColumnName("FisheryGYoYY90P");
			this.Property(t => t.TotalOutputValueIndex).HasColumnName("TotalOutputValueIndex");
			this.Property(t => t.AgricultureIndex).HasColumnName("AgricultureIndex");
			this.Property(t => t.ForestryIndex).HasColumnName("ForestryIndex");
			this.Property(t => t.AnimalHusbandryIndex).HasColumnName("AnimalHusbandryIndex");
			this.Property(t => t.FisheryIndex).HasColumnName("FisheryIndex");
			this.Property(t => t.TotalPowerOfAgrMachinery).HasColumnName("TotalPowerOfAgrMachinery");
			this.Property(t => t.MediumLargeTractorsNum).HasColumnName("MediumLargeTractorsNum");
			this.Property(t => t.MediumLargeTractorsPower).HasColumnName("MediumLargeTractorsPower");
			this.Property(t => t.SmallTractorsNum).HasColumnName("SmallTractorsNum");
			this.Property(t => t.SmallTractorsPower).HasColumnName("SmallTractorsPower");
			this.Property(t => t.MLTractorDrivenImplements).HasColumnName("MLTractorDrivenImplements");
			this.Property(t => t.STractorDrivenImplements).HasColumnName("STractorDrivenImplements");
			this.Property(t => t.RuralDieselEngineeIDNum).HasColumnName("RuralDieselEngineeIDNum");
			this.Property(t => t.RuralDieselEngineeIDPower).HasColumnName("RuralDieselEngineeIDPower");
			this.Property(t => t.RuralLoadingAutoNum).HasColumnName("RuralLoadingAutoNum");
			this.Property(t => t.RuralLoadingAutoPower).HasColumnName("RuralLoadingAutoPower");
			this.Property(t => t.FishingPowerboatNum).HasColumnName("FishingPowerboatNum");
			this.Property(t => t.FishingPowerboatPower).HasColumnName("FishingPowerboatPower");
			this.Property(t => t.EffectiveIrrigationArea).HasColumnName("EffectiveIrrigationArea");
			this.Property(t => t.TotalFertilizerUsage).HasColumnName("TotalFertilizerUsage");
			this.Property(t => t.NitroFertilizerUsage).HasColumnName("NitroFertilizerUsage");
			this.Property(t => t.PotashFertilierUsage).HasColumnName("PotashFertilierUsage");
			this.Property(t => t.PhosphateFertilizerUsage).HasColumnName("PhosphateFertilizerUsage");
			this.Property(t => t.CompositeFertilizerUsage).HasColumnName("CompositeFertilizerUsage");
			this.Property(t => t.ElectricityGeneratorNum).HasColumnName("ElectricityGeneratorNum");
			this.Property(t => t.ElectricityGeneratorPower).HasColumnName("ElectricityGeneratorPower");
			this.Property(t => t.ElectricityConsumption).HasColumnName("ElectricityConsumption");
			this.Property(t => t.RuralFarmingWorkers).HasColumnName("RuralFarmingWorkers");
			this.Property(t => t.RuralWorkersIndustrial).HasColumnName("RuralWorkersIndustrial");
			this.Property(t => t.RuralWorkersConstruction).HasColumnName("RuralWorkersConstruction");
			this.Property(t => t.RuralWorkersTWPT).HasColumnName("RuralWorkersTWPT");
			this.Property(t => t.RuralWorkersWRFB).HasColumnName("RuralWorkersWRFB");
			this.Property(t => t.RuralWorkersOtherNonAgri).HasColumnName("RuralWorkersOtherNonAgri");
			this.Property(t => t.FAInvOnForestry).HasColumnName("FAInvOnForestry");
			this.Property(t => t.FAInvOperatingForestry).HasColumnName("FAInvOperatingForestry");
			this.Property(t => t.BasicConstructionInvOF).HasColumnName("BasicConstructionInvOF");
			this.Property(t => t.UpgradeInnovationInvOF).HasColumnName("UpgradeInnovationInvOF");
			this.Property(t => t.FAInvForestProject).HasColumnName("FAInvForestProject");
			this.Property(t => t.FAInvFP).HasColumnName("FAInvFP");
			this.Property(t => t.BasicConstrctionInvFP).HasColumnName("BasicConstrctionInvFP");
			this.Property(t => t.UpgradeInnovationInvFP).HasColumnName("UpgradeInnovationInvFP");
			this.Property(t => t.CalamityStrickenArea).HasColumnName("CalamityStrickenArea");
			this.Property(t => t.FloodStrickenArea).HasColumnName("FloodStrickenArea");
			this.Property(t => t.DroughtStrickenArea).HasColumnName("DroughtStrickenArea");
			this.Property(t => t.CalamityInfestedArea).HasColumnName("CalamityInfestedArea");
			this.Property(t => t.FloodInfestedArea).HasColumnName("FloodInfestedArea");
			this.Property(t => t.DroughtInfestedArea).HasColumnName("DroughtInfestedArea");
			this.Property(t => t.EffectiveIrrigatedArea).HasColumnName("EffectiveIrrigatedArea");
			this.Property(t => t.WaterReserveIA).HasColumnName("WaterReserveIA");
			this.Property(t => t.FloodProtectedArea).HasColumnName("FloodProtectedArea");
			this.Property(t => t.WaterSoilLossProtectedArea).HasColumnName("WaterSoilLossProtectedArea");
			this.Property(t => t.AlkaliControlledArea).HasColumnName("AlkaliControlledArea");
			this.Property(t => t.DikeLength).HasColumnName("DikeLength");
			this.Property(t => t.DikeProtectedArea).HasColumnName("DikeProtectedArea");
			this.Property(t => t.ActualArableLandAreaYE).HasColumnName("ActualArableLandAreaYE");
			this.Property(t => t.ReducedArableLandArea).HasColumnName("ReducedArableLandArea");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

