using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_EquityAdjustmentMap : EntityTypeConfiguration<LC_EquityAdjustment>
	{
		public LC_EquityAdjustmentMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_EquityAdjustment");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.StoHolEquity_OAS).HasColumnName("StoHolEquity_OAS");
			this.Property(t => t.LTEIDS).HasColumnName("LTEIDS");
			this.Property(t => t.SLTEIDS).HasColumnName("SLTEIDS");
			this.Property(t => t.EECLTIA).HasColumnName("EECLTIA");
			this.Property(t => t.FVIH).HasColumnName("FVIH");
			this.Property(t => t.Depreciation).HasColumnName("Depreciation");
			this.Property(t => t.ResignComp).HasColumnName("ResignComp");
			this.Property(t => t.ShareTran).HasColumnName("ShareTran");
			this.Property(t => t.ReorgDuty).HasColumnName("ReorgDuty");
			this.Property(t => t.Merge).HasColumnName("Merge");
			this.Property(t => t.GWAV).HasColumnName("GWAV");
			this.Property(t => t.GWR).HasColumnName("GWR");
			this.Property(t => t.FVFASFA).HasColumnName("FVFASFA");
			this.Property(t => t.FVFD).HasColumnName("FVFD");
			this.Property(t => t.SFTII).HasColumnName("SFTII");
			this.Property(t => t.DFT).HasColumnName("DFT");
			this.Property(t => t.Tax).HasColumnName("Tax");
			this.Property(t => t.Other).HasColumnName("Other");
			this.Property(t => t.StoHolEquity_NAS).HasColumnName("StoHolEquity_NAS");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
		}
	}
}

