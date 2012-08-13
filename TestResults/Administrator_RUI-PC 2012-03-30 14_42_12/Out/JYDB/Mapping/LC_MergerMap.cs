using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MergerMap : EntityTypeConfiguration<LC_Merger>
	{
		public LC_MergerMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.MergedParty)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.MainBusinesses)
				.HasMaxLength(200);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_Merger");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.PreSchemePublDate).HasColumnName("PreSchemePublDate");
			this.Property(t => t.AnouncementPublDate).HasColumnName("AnouncementPublDate");
			this.Property(t => t.MergedParty).HasColumnName("MergedParty");
			this.Property(t => t.FoundedDate).HasColumnName("FoundedDate");
			this.Property(t => t.RegiCapital).HasColumnName("RegiCapital");
			this.Property(t => t.MainBusinesses).HasColumnName("MainBusinesses");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.MergeBaseDate).HasColumnName("MergeBaseDate");
			this.Property(t => t.AgreementDate).HasColumnName("AgreementDate");
			this.Property(t => t.ExchangeRateNumerator).HasColumnName("ExchangeRateNumerator");
			this.Property(t => t.ExchangeRateDenominator).HasColumnName("ExchangeRateDenominator");
			this.Property(t => t.ContraShares).HasColumnName("ContraShares");
			this.Property(t => t.IssueShares).HasColumnName("IssueShares");
			this.Property(t => t.StateSharesAdded).HasColumnName("StateSharesAdded");
			this.Property(t => t.LegalPersonSharesAdded).HasColumnName("LegalPersonSharesAdded");
			this.Property(t => t.IndividualSharesAdded).HasColumnName("IndividualSharesAdded");
			this.Property(t => t.ISharesAddedHoldingPeriod).HasColumnName("ISharesAddedHoldingPeriod");
			this.Property(t => t.ShareExchangeBeginDate).HasColumnName("ShareExchangeBeginDate");
			this.Property(t => t.ShareExchangeEndDate).HasColumnName("ShareExchangeEndDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.ShareholderEquity).HasColumnName("ShareholderEquity");
			this.Property(t => t.MainBusinessIncome).HasColumnName("MainBusinessIncome");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.ShareChangePublDate).HasColumnName("ShareChangePublDate");
			this.Property(t => t.ShareCapitalBeforeMerge).HasColumnName("ShareCapitalBeforeMerge");
			this.Property(t => t.ShareCustodyDate).HasColumnName("ShareCustodyDate");
			this.Property(t => t.ICChangeRegiDate).HasColumnName("ICChangeRegiDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.MergedCompanyCode).HasColumnName("MergedCompanyCode");
			this.Property(t => t.MergedInnerCode).HasColumnName("MergedInnerCode");
			this.Property(t => t.ExchangeRightRegDate).HasColumnName("ExchangeRightRegDate");
			this.Property(t => t.ShareListDate).HasColumnName("ShareListDate");
		}
	}
}

