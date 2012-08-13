using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_RConsiderationMap : EntityTypeConfiguration<LC_RConsideration>
	{
		public LC_RConsiderationMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Program)
				.HasMaxLength(500);
				
			this.Property(t => t.Notes)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_RConsideration");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.LatestInfoPublDate).HasColumnName("LatestInfoPublDate");
			this.Property(t => t.IfEffected).HasColumnName("IfEffected");
			this.Property(t => t.ProgramType).HasColumnName("ProgramType");
			this.Property(t => t.GainerHolding).HasColumnName("GainerHolding");
			this.Property(t => t.Tshare).HasColumnName("Tshare");
			this.Property(t => t.NTShare).HasColumnName("NTShare");
			this.Property(t => t.CompanyGrantedShare).HasColumnName("CompanyGrantedShare");
			this.Property(t => t.NTSHTranPaid).HasColumnName("NTSHTranPaid");
			this.Property(t => t.CompanyTransformedShare).HasColumnName("CompanyTransformedShare");
			this.Property(t => t.NTSHTranPaidTShare).HasColumnName("NTSHTranPaidTShare");
			this.Property(t => t.CompanyPaidCashBT).HasColumnName("CompanyPaidCashBT");
			this.Property(t => t.NTSHTranPaidCash).HasColumnName("NTSHTranPaidCash");
			this.Property(t => t.CompanyWarrantRate).HasColumnName("CompanyWarrantRate");
			this.Property(t => t.NTSNTranWarrant).HasColumnName("NTSNTranWarrant");
			this.Property(t => t.CompanyGTShare).HasColumnName("CompanyGTShare");
			this.Property(t => t.CompanyPaidCash).HasColumnName("CompanyPaidCash");
			this.Property(t => t.CompanyWarrant).HasColumnName("CompanyWarrant");
			this.Property(t => t.ShareConsiderationRate).HasColumnName("ShareConsiderationRate");
			this.Property(t => t.CashConsiderationRateBT).HasColumnName("CashConsiderationRateBT");
			this.Property(t => t.ShareConsideration).HasColumnName("ShareConsideration");
			this.Property(t => t.CashConsiderationR).HasColumnName("CashConsiderationR");
			this.Property(t => t.WarrantConsiderationRate).HasColumnName("WarrantConsiderationRate");
			this.Property(t => t.CallWarrant).HasColumnName("CallWarrant");
			this.Property(t => t.PutWarrant).HasColumnName("PutWarrant");
			this.Property(t => t.WarrantConsideration).HasColumnName("WarrantConsideration");
			this.Property(t => t.RatioOfNTShareBCompressed).HasColumnName("RatioOfNTShareBCompressed");
			this.Property(t => t.RatioOfNTShareACompressed).HasColumnName("RatioOfNTShareACompressed");
			this.Property(t => t.ShareCompressedOfNTShare).HasColumnName("ShareCompressedOfNTShare");
			this.Property(t => t.Program).HasColumnName("Program");
			this.Property(t => t.PricingBasis).HasColumnName("PricingBasis");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.GainerShareKind).HasColumnName("GainerShareKind");
			this.Property(t => t.GTSharefromCompany).HasColumnName("GTSharefromCompany");
			this.Property(t => t.CashBTfromCompany).HasColumnName("CashBTfromCompany");
			this.Property(t => t.WarrantfromCompany).HasColumnName("WarrantfromCompany");
			this.Property(t => t.CompanyPaidCashAT).HasColumnName("CompanyPaidCashAT");
			this.Property(t => t.CashATfromCompany).HasColumnName("CashATfromCompany");
			this.Property(t => t.CashConsiderationRateAT).HasColumnName("CashConsiderationRateAT");
			this.Property(t => t.PresenterHolding).HasColumnName("PresenterHolding");
			this.Property(t => t.RatioInNTSH).HasColumnName("RatioInNTSH");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

