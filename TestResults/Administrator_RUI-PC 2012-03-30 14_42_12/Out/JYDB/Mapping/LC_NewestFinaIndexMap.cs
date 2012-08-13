using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NewestFinaIndexMap : EntityTypeConfiguration<LC_NewestFinaIndex>
	{
		public LC_NewestFinaIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.AdjustDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AdjustReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_NewestFinaIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.AdjustDate).HasColumnName("AdjustDate");
			this.Property(t => t.AdjustReason).HasColumnName("AdjustReason");
			this.Property(t => t.ShareCapitalBeforeAdjust).HasColumnName("ShareCapitalBeforeAdjust");
			this.Property(t => t.SHareCapitalIncr).HasColumnName("SHareCapitalIncr");
			this.Property(t => t.ShareCapitalAftereAdjust).HasColumnName("ShareCapitalAftereAdjust");
			this.Property(t => t.CapitalReserveBeforeAdjust).HasColumnName("CapitalReserveBeforeAdjust");
			this.Property(t => t.CapitalReserveIncr).HasColumnName("CapitalReserveIncr");
			this.Property(t => t.CapitalReserveAfterAdjust).HasColumnName("CapitalReserveAfterAdjust");
			this.Property(t => t.RetainedProfitBeforeAdjust).HasColumnName("RetainedProfitBeforeAdjust");
			this.Property(t => t.RetainedProfitIncr).HasColumnName("RetainedProfitIncr");
			this.Property(t => t.RetainedProfitAfterAdjust).HasColumnName("RetainedProfitAfterAdjust");
			this.Property(t => t.SurplusReserveBeforeAdjust).HasColumnName("SurplusReserveBeforeAdjust");
			this.Property(t => t.SurplusReserveIncr).HasColumnName("SurplusReserveIncr");
			this.Property(t => t.SurplusReserveAfterAdjust).HasColumnName("SurplusReserveAfterAdjust");
			this.Property(t => t.NetAssetBeforeAdjust).HasColumnName("NetAssetBeforeAdjust");
			this.Property(t => t.NetAssetIncr).HasColumnName("NetAssetIncr");
			this.Property(t => t.NetAssetAfterAdjust).HasColumnName("NetAssetAfterAdjust");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.NAPS).HasColumnName("NAPS");
			this.Property(t => t.RetainedProfitPS).HasColumnName("RetainedProfitPS");
			this.Property(t => t.CapitalReservePS).HasColumnName("CapitalReservePS");
			this.Property(t => t.NetOperateCashFlowPS).HasColumnName("NetOperateCashFlowPS");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

