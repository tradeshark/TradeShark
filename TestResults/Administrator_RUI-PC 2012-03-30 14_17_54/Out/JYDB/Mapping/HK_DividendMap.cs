using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_DividendMap : EntityTypeConfiguration<HK_Dividend>
	{
		public HK_DividendMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_Dividend");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.Process).HasColumnName("Process");
			this.Property(t => t.DMPublDate).HasColumnName("DMPublDate");
			this.Property(t => t.DMSignDate).HasColumnName("DMSignDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.ListingPublDate).HasColumnName("ListingPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.DividendPeriod).HasColumnName("DividendPeriod");
			this.Property(t => t.FiscalYear).HasColumnName("FiscalYear");
			this.Property(t => t.IfDividend).HasColumnName("IfDividend");
			this.Property(t => t.DividendType).HasColumnName("DividendType");
			this.Property(t => t.DividendUnit).HasColumnName("DividendUnit");
			this.Property(t => t.CashDividendPS).HasColumnName("CashDividendPS");
			this.Property(t => t.OtherOption).HasColumnName("OtherOption");
			this.Property(t => t.SpecialDividendPS).HasColumnName("SpecialDividendPS");
			this.Property(t => t.SpecialDividendSubstitute).HasColumnName("SpecialDividendSubstitute");
			this.Property(t => t.ShareDividendRateX).HasColumnName("ShareDividendRateX");
			this.Property(t => t.ShareDividendRateY).HasColumnName("ShareDividendRateY");
			this.Property(t => t.WarrantDividendRateX).HasColumnName("WarrantDividendRateX");
			this.Property(t => t.WarrantDividendRateY).HasColumnName("WarrantDividendRateY");
			this.Property(t => t.PhysicalDividendRateX).HasColumnName("PhysicalDividendRateX");
			this.Property(t => t.PhysicalDividendRateY).HasColumnName("PhysicalDividendRateY");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.TotalCashDividend).HasColumnName("TotalCashDividend");
			this.Property(t => t.DividendBase).HasColumnName("DividendBase");
			this.Property(t => t.DividendBaseShares).HasColumnName("DividendBaseShares");
			this.Property(t => t.TotalShareDividend).HasColumnName("TotalShareDividend");
			this.Property(t => t.TotalWarrantDividend).HasColumnName("TotalWarrantDividend");
			this.Property(t => t.LastTradeDay).HasColumnName("LastTradeDay");
			this.Property(t => t.ExDate).HasColumnName("ExDate");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
			this.Property(t => t.TransferBeginDate).HasColumnName("TransferBeginDate");
			this.Property(t => t.TransferEndDate).HasColumnName("TransferEndDate");
			this.Property(t => t.DividendPayableDate).HasColumnName("DividendPayableDate");
			this.Property(t => t.PayoutDate).HasColumnName("PayoutDate");
			this.Property(t => t.ShareDiviListingDate).HasColumnName("ShareDiviListingDate");
			this.Property(t => t.ScripDividendIssuePrice).HasColumnName("ScripDividendIssuePrice");
			this.Property(t => t.ScripDividendPayoutDate).HasColumnName("ScripDividendPayoutDate");
			this.Property(t => t.ScripDividendListingDate).HasColumnName("ScripDividendListingDate");
			this.Property(t => t.ScripDividendSum).HasColumnName("ScripDividendSum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

