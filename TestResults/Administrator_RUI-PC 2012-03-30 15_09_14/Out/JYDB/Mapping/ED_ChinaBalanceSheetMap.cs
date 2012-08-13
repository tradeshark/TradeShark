using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ChinaBalanceSheetMap : EntityTypeConfiguration<ED_ChinaBalanceSheet>
	{
		public ED_ChinaBalanceSheetMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.AccountCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.AccountCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_ChinaBalanceSheet");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AccountCode).HasColumnName("AccountCode");
			this.Property(t => t.CurrentAccount).HasColumnName("CurrentAccount");
			this.Property(t => t.GoodsServices).HasColumnName("GoodsServices");
			this.Property(t => t.Goods).HasColumnName("Goods");
			this.Property(t => t.Exports).HasColumnName("Exports");
			this.Property(t => t.Imports).HasColumnName("Imports");
			this.Property(t => t.Services).HasColumnName("Services");
			this.Property(t => t.Transportations).HasColumnName("Transportations");
			this.Property(t => t.Tourisms).HasColumnName("Tourisms");
			this.Property(t => t.ComminicationServices).HasColumnName("ComminicationServices");
			this.Property(t => t.Construction).HasColumnName("Construction");
			this.Property(t => t.Insurance).HasColumnName("Insurance");
			this.Property(t => t.FinancialService).HasColumnName("FinancialService");
			this.Property(t => t.ComputerAndITServices).HasColumnName("ComputerAndITServices");
			this.Property(t => t.PremiumLoyaltPRRights).HasColumnName("PremiumLoyaltPRRights");
			this.Property(t => t.Consultancy).HasColumnName("Consultancy");
			this.Property(t => t.AdvertisementPublivity).HasColumnName("AdvertisementPublivity");
			this.Property(t => t.MoviesAudioVidios).HasColumnName("MoviesAudioVidios");
			this.Property(t => t.OtherCommercialServices).HasColumnName("OtherCommercialServices");
			this.Property(t => t.OtherNoMentionedGovServices).HasColumnName("OtherNoMentionedGovServices");
			this.Property(t => t.ProfitsOrRevenues).HasColumnName("ProfitsOrRevenues");
			this.Property(t => t.EmployeesSalary).HasColumnName("EmployeesSalary");
			this.Property(t => t.InvestmentReturns).HasColumnName("InvestmentReturns");
			this.Property(t => t.ConstanTransfer).HasColumnName("ConstanTransfer");
			this.Property(t => t.IntraGovernemts).HasColumnName("IntraGovernemts");
			this.Property(t => t.OtherOrganizations).HasColumnName("OtherOrganizations");
			this.Property(t => t.CapitalAndFinancialAccount).HasColumnName("CapitalAndFinancialAccount");
			this.Property(t => t.CapitalAccount).HasColumnName("CapitalAccount");
			this.Property(t => t.FinancialAccount).HasColumnName("FinancialAccount");
			this.Property(t => t.DirectInvestment).HasColumnName("DirectInvestment");
			this.Property(t => t.ChinaDInvOverseas).HasColumnName("ChinaDInvOverseas");
			this.Property(t => t.ForeignDInvInChina).HasColumnName("ForeignDInvInChina");
			this.Property(t => t.StockInvestment).HasColumnName("StockInvestment");
			this.Property(t => t.StockAssets).HasColumnName("StockAssets");
			this.Property(t => t.EquityInvestment).HasColumnName("EquityInvestment");
			this.Property(t => t.DebtsInvestment).HasColumnName("DebtsInvestment");
			this.Property(t => t.MediumOrLongTermBonds).HasColumnName("MediumOrLongTermBonds");
			this.Property(t => t.moneyMarketsInstruments).HasColumnName("moneyMarketsInstruments");
			this.Property(t => t.Liability).HasColumnName("Liability");
			this.Property(t => t.EquitySecurities).HasColumnName("EquitySecurities");
			this.Property(t => t.DebtsSecurities).HasColumnName("DebtsSecurities");
			this.Property(t => t.MediumOrLongTermBondsLi).HasColumnName("MediumOrLongTermBondsLi");
			this.Property(t => t.moneyMarketsInstrumentsLi).HasColumnName("moneyMarketsInstrumentsLi");
			this.Property(t => t.OtherInvestment).HasColumnName("OtherInvestment");
			this.Property(t => t.Assets).HasColumnName("Assets");
			this.Property(t => t.TradeLoan).HasColumnName("TradeLoan");
			this.Property(t => t.LongTermTL).HasColumnName("LongTermTL");
			this.Property(t => t.ShortTermTL).HasColumnName("ShortTermTL");
			this.Property(t => t.Loans).HasColumnName("Loans");
			this.Property(t => t.LongTermL).HasColumnName("LongTermL");
			this.Property(t => t.ShortTermL).HasColumnName("ShortTermL");
			this.Property(t => t.moneyandSavings).HasColumnName("moneyandSavings");
			this.Property(t => t.OtherAssets).HasColumnName("OtherAssets");
			this.Property(t => t.LongTermOA).HasColumnName("LongTermOA");
			this.Property(t => t.ShortTermOA).HasColumnName("ShortTermOA");
			this.Property(t => t.LiabilityOI).HasColumnName("LiabilityOI");
			this.Property(t => t.TradeBorrowing).HasColumnName("TradeBorrowing");
			this.Property(t => t.LongTermTB).HasColumnName("LongTermTB");
			this.Property(t => t.ShortTermTB).HasColumnName("ShortTermTB");
			this.Property(t => t.Borrowings).HasColumnName("Borrowings");
			this.Property(t => t.LongTermB).HasColumnName("LongTermB");
			this.Property(t => t.ShortTermB).HasColumnName("ShortTermB");
			this.Property(t => t.moneyAndSavingsLi).HasColumnName("moneyAndSavingsLi");
			this.Property(t => t.OtherLiabilities).HasColumnName("OtherLiabilities");
			this.Property(t => t.LongTermOL).HasColumnName("LongTermOL");
			this.Property(t => t.ShortTermOL).HasColumnName("ShortTermOL");
			this.Property(t => t.ReserveAssets).HasColumnName("ReserveAssets");
			this.Property(t => t.moneyGold).HasColumnName("moneyGold");
			this.Property(t => t.SDR).HasColumnName("SDR");
			this.Property(t => t.ReservesAtIMF).HasColumnName("ReservesAtIMF");
			this.Property(t => t.Forex).HasColumnName("Forex");
			this.Property(t => t.OtherCredits).HasColumnName("OtherCredits");
			this.Property(t => t.Totals).HasColumnName("Totals");
			this.Property(t => t.ErrorsOmmisions).HasColumnName("ErrorsOmmisions");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

