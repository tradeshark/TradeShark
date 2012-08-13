using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class SM_SecuAccountMap : EntityTypeConfiguration<SM_SecuAccount>
	{
		public SM_SecuAccountMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("SM_SecuAccount");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.AccountAccu).HasColumnName("AccountAccu");
			this.Property(t => t.AccountAccuA).HasColumnName("AccountAccuA");
			this.Property(t => t.AccountAccuAIndv).HasColumnName("AccountAccuAIndv");
			this.Property(t => t.AccountAccuAInst).HasColumnName("AccountAccuAInst");
			this.Property(t => t.AccountAccuB).HasColumnName("AccountAccuB");
			this.Property(t => t.AccountAccuBIndv).HasColumnName("AccountAccuBIndv");
			this.Property(t => t.AccountAccuBInst).HasColumnName("AccountAccuBInst");
			this.Property(t => t.AccountAccuFund).HasColumnName("AccountAccuFund");
			this.Property(t => t.AccountAccuFundIndv).HasColumnName("AccountAccuFundIndv");
			this.Property(t => t.AccountAccuFundInst).HasColumnName("AccountAccuFundInst");
			this.Property(t => t.AccountAccuAandFund).HasColumnName("AccountAccuAandFund");
			this.Property(t => t.AccountNew).HasColumnName("AccountNew");
			this.Property(t => t.AccountNewA).HasColumnName("AccountNewA");
			this.Property(t => t.AccountNewAIndv).HasColumnName("AccountNewAIndv");
			this.Property(t => t.AccountNewAInst).HasColumnName("AccountNewAInst");
			this.Property(t => t.AccountNewAInstNormal).HasColumnName("AccountNewAInstNormal");
			this.Property(t => t.AccountNewAInstSecuCo).HasColumnName("AccountNewAInstSecuCo");
			this.Property(t => t.AccountNewAInstFundCo).HasColumnName("AccountNewAInstFundCo");
			this.Property(t => t.AccountNewAInstSSF).HasColumnName("AccountNewAInstSSF");
			this.Property(t => t.AccountNewAInstQFII).HasColumnName("AccountNewAInstQFII");
			this.Property(t => t.AccountNewB).HasColumnName("AccountNewB");
			this.Property(t => t.AccountNewBIndv).HasColumnName("AccountNewBIndv");
			this.Property(t => t.AccountNewBIndvDom).HasColumnName("AccountNewBIndvDom");
			this.Property(t => t.AccountNewBIndvFor).HasColumnName("AccountNewBIndvFor");
			this.Property(t => t.AccountNewBInst).HasColumnName("AccountNewBInst");
			this.Property(t => t.AccountNewBInstFor).HasColumnName("AccountNewBInstFor");
			this.Property(t => t.AccountNewFund).HasColumnName("AccountNewFund");
			this.Property(t => t.AccountNewFundIndv).HasColumnName("AccountNewFundIndv");
			this.Property(t => t.AccountNewFundInst).HasColumnName("AccountNewFundInst");
			this.Property(t => t.AccountNewAandFund).HasColumnName("AccountNewAandFund");
			this.Property(t => t.AccountNewOTC).HasColumnName("AccountNewOTC");
			this.Property(t => t.AccountCloseAccu).HasColumnName("AccountCloseAccu");
			this.Property(t => t.AccountCloseAccuA).HasColumnName("AccountCloseAccuA");
			this.Property(t => t.AccountCloseAccuB).HasColumnName("AccountCloseAccuB");
			this.Property(t => t.AccountCloseAccuFund).HasColumnName("AccountCloseAccuFund");
			this.Property(t => t.AccountCloseNew).HasColumnName("AccountCloseNew");
			this.Property(t => t.AccountCloseNewA).HasColumnName("AccountCloseNewA");
			this.Property(t => t.AccountCloseNewAIndv).HasColumnName("AccountCloseNewAIndv");
			this.Property(t => t.AccountCloseNewAInst).HasColumnName("AccountCloseNewAInst");
			this.Property(t => t.AccountCloseNewB).HasColumnName("AccountCloseNewB");
			this.Property(t => t.AccountCloseNewBIndv).HasColumnName("AccountCloseNewBIndv");
			this.Property(t => t.AccountCloseNewBInst).HasColumnName("AccountCloseNewBInst");
			this.Property(t => t.AccountCloseNewFund).HasColumnName("AccountCloseNewFund");
			this.Property(t => t.AccountCloseNewFundIndv).HasColumnName("AccountCloseNewFundIndv");
			this.Property(t => t.AccountCloseNewFundInst).HasColumnName("AccountCloseNewFundInst");
			this.Property(t => t.AccountEndPer).HasColumnName("AccountEndPer");
			this.Property(t => t.AccountEndPerIndv).HasColumnName("AccountEndPerIndv");
			this.Property(t => t.AccountEndPerInst).HasColumnName("AccountEndPerInst");
			this.Property(t => t.AccountEndPerA).HasColumnName("AccountEndPerA");
			this.Property(t => t.AccountEndPerAIndv).HasColumnName("AccountEndPerAIndv");
			this.Property(t => t.AccountEndPerAInst).HasColumnName("AccountEndPerAInst");
			this.Property(t => t.AccountEndPerAInstNormal).HasColumnName("AccountEndPerAInstNormal");
			this.Property(t => t.AccountEndPerAInstSecuCo).HasColumnName("AccountEndPerAInstSecuCo");
			this.Property(t => t.AccountEndPerAInstFundCo).HasColumnName("AccountEndPerAInstFundCo");
			this.Property(t => t.AccountEndPerAInstSSF).HasColumnName("AccountEndPerAInstSSF");
			this.Property(t => t.AccountEndPerAInstQFII).HasColumnName("AccountEndPerAInstQFII");
			this.Property(t => t.AccountEndPerB).HasColumnName("AccountEndPerB");
			this.Property(t => t.AccountEndPerBIndv).HasColumnName("AccountEndPerBIndv");
			this.Property(t => t.AccountEndPerBIndvDom).HasColumnName("AccountEndPerBIndvDom");
			this.Property(t => t.AccountEndPerBIndvFor).HasColumnName("AccountEndPerBIndvFor");
			this.Property(t => t.AccountEndPerBInst).HasColumnName("AccountEndPerBInst");
			this.Property(t => t.AccountEndPerBInstFor).HasColumnName("AccountEndPerBInstFor");
			this.Property(t => t.AccountEndPerFund).HasColumnName("AccountEndPerFund");
			this.Property(t => t.AccountEndPerFundIndv).HasColumnName("AccountEndPerFundIndv");
			this.Property(t => t.AccountEndPerFundInst).HasColumnName("AccountEndPerFundInst");
			this.Property(t => t.AccountCarrierEndPer).HasColumnName("AccountCarrierEndPer");
			this.Property(t => t.AccountCarrierEndPerA).HasColumnName("AccountCarrierEndPerA");
			this.Property(t => t.AccountCarrierEndPerASecuCo).HasColumnName("AccountCarrierEndPerASecuCo");
			this.Property(t => t.AccountCarrierEndPerABank).HasColumnName("AccountCarrierEndPerABank");
			this.Property(t => t.AccountCarrierEndPerB).HasColumnName("AccountCarrierEndPerB");
			this.Property(t => t.AccountCarrierNew).HasColumnName("AccountCarrierNew");
			this.Property(t => t.AccountCarrierNewA).HasColumnName("AccountCarrierNewA");
			this.Property(t => t.AccountCarrierNewB).HasColumnName("AccountCarrierNewB");
			this.Property(t => t.AccountCarrierBrEndPer).HasColumnName("AccountCarrierBrEndPer");
			this.Property(t => t.AccountCarrierBrEndPerA).HasColumnName("AccountCarrierBrEndPerA");
			this.Property(t => t.AccountCarrierBrEndPerB).HasColumnName("AccountCarrierBrEndPerB");
			this.Property(t => t.AccountCarrierBrNew).HasColumnName("AccountCarrierBrNew");
			this.Property(t => t.AccountCarrierBrNewA).HasColumnName("AccountCarrierBrNewA");
			this.Property(t => t.AccountCarrierBrNewB).HasColumnName("AccountCarrierBrNewB");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.IncreasedStockAccountN).HasColumnName("IncreasedStockAccountN");
			this.Property(t => t.IncrClosedFundAccountN).HasColumnName("IncrClosedFundAccountN");
			this.Property(t => t.IncrTAFundAccountN).HasColumnName("IncrTAFundAccountN");
			this.Property(t => t.EndingStockAccountN).HasColumnName("EndingStockAccountN");
			this.Property(t => t.EndingAStoAccNHolding).HasColumnName("EndingAStoAccNHolding");
			this.Property(t => t.EndingAStoAccNTrading).HasColumnName("EndingAStoAccNTrading");
			this.Property(t => t.EndingDormantAccountN).HasColumnName("EndingDormantAccountN");
			this.Property(t => t.EndingEffectiveAccountN).HasColumnName("EndingEffectiveAccountN");
		}
	}
}

