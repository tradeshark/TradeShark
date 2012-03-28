using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_CorporateGoodsPIMap : EntityTypeConfiguration<ED_CorporateGoodsPI>
	{
		public ED_CorporateGoodsPIMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_CorporateGoodsPI");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.CGPIGeneralIndex).HasColumnName("CGPIGeneralIndex");
			this.Property(t => t.CGPIFarmProduct).HasColumnName("CGPIFarmProduct");
			this.Property(t => t.CGPIMineralProduct).HasColumnName("CGPIMineralProduct");
			this.Property(t => t.CGPICoalOilElectricity).HasColumnName("CGPICoalOilElectricity");
			this.Property(t => t.CGPIProcessedGoods).HasColumnName("CGPIProcessedGoods");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

