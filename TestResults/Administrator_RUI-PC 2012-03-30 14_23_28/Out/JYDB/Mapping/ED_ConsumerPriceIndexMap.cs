using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ConsumerPriceIndexMap : EntityTypeConfiguration<ED_ConsumerPriceIndex>
	{
		public ED_ConsumerPriceIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_ConsumerPriceIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.CPI).HasColumnName("CPI");
			this.Property(t => t.CPIFood).HasColumnName("CPIFood");
			this.Property(t => t.CPIGrain).HasColumnName("CPIGrain");
			this.Property(t => t.CPIMeatPoultry).HasColumnName("CPIMeatPoultry");
			this.Property(t => t.CPIEgg).HasColumnName("CPIEgg");
			this.Property(t => t.CPIFishandSeaFood).HasColumnName("CPIFishandSeaFood");
			this.Property(t => t.CPIVegetable).HasColumnName("CPIVegetable");
			this.Property(t => t.CPIFruits).HasColumnName("CPIFruits");
			this.Property(t => t.CPIEatOut).HasColumnName("CPIEatOut");
			this.Property(t => t.CPITobacco).HasColumnName("CPITobacco");
			this.Property(t => t.CPICloth).HasColumnName("CPICloth");
			this.Property(t => t.CPIFamilyEquipmentService).HasColumnName("CPIFamilyEquipmentService");
			this.Property(t => t.CPIMedicare).HasColumnName("CPIMedicare");
			this.Property(t => t.CPITrafficCommunication).HasColumnName("CPITrafficCommunication");
			this.Property(t => t.CPIEntertainmentService).HasColumnName("CPIEntertainmentService");
			this.Property(t => t.CPIHousing).HasColumnName("CPIHousing");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

