using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ProsperityIndexMap : EntityTypeConfiguration<ED_ProsperityIndex>
	{
		public ED_ProsperityIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_ProsperityIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.Category).HasColumnName("Category");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.Construction).HasColumnName("Construction");
			this.Property(t => t.TrafficStoragePostTelecom).HasColumnName("TrafficStoragePostTelecom");
			this.Property(t => t.WRTradeFoodBeverage).HasColumnName("WRTradeFoodBeverage");
			this.Property(t => t.WholesaleRetail).HasColumnName("WholesaleRetail");
			this.Property(t => t.HotelFoodBeverage).HasColumnName("HotelFoodBeverage");
			this.Property(t => t.RealEstate).HasColumnName("RealEstate");
			this.Property(t => t.SocialService).HasColumnName("SocialService");
			this.Property(t => t.InfoComputerSoftware).HasColumnName("InfoComputerSoftware");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

