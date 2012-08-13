using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_StockHoldingStMap : EntityTypeConfiguration<LC_StockHoldingSt>
	{
		public LC_StockHoldingStMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_StockHoldingSt");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.InstitutionsHoldings).HasColumnName("InstitutionsHoldings");
			this.Property(t => t.FundsHoldings).HasColumnName("FundsHoldings");
			this.Property(t => t.SecuritiesCorpsHoldings).HasColumnName("SecuritiesCorpsHoldings");
			this.Property(t => t.FinancingProductsHoldings).HasColumnName("FinancingProductsHoldings");
			this.Property(t => t.QFIIHoldings).HasColumnName("QFIIHoldings");
			this.Property(t => t.InsuranceCorpsHoldings).HasColumnName("InsuranceCorpsHoldings");
			this.Property(t => t.SocialSecurityFundHold).HasColumnName("SocialSecurityFundHold");
			this.Property(t => t.EnterpriseAnnuitiesHold).HasColumnName("EnterpriseAnnuitiesHold");
			this.Property(t => t.TrustCompaniesHoldings).HasColumnName("TrustCompaniesHoldings");
			this.Property(t => t.FinanceCompaniesHoldings).HasColumnName("FinanceCompaniesHoldings");
			this.Property(t => t.OtherInstitutionHoldings).HasColumnName("OtherInstitutionHoldings");
			this.Property(t => t.InstitutionsHoldProp).HasColumnName("InstitutionsHoldProp");
			this.Property(t => t.FundsHoldProp).HasColumnName("FundsHoldProp");
			this.Property(t => t.SecuritiesCorpsHoldProp).HasColumnName("SecuritiesCorpsHoldProp");
			this.Property(t => t.FinancingProductsHoldProp).HasColumnName("FinancingProductsHoldProp");
			this.Property(t => t.QFIIHoldProp).HasColumnName("QFIIHoldProp");
			this.Property(t => t.InsuranceCorpsHoldProp).HasColumnName("InsuranceCorpsHoldProp");
			this.Property(t => t.SocialSecuFundHoldProp).HasColumnName("SocialSecuFundHoldProp");
			this.Property(t => t.CorpAnnuitiesHoldProp).HasColumnName("CorpAnnuitiesHoldProp");
			this.Property(t => t.TrustCompaniesHoldProp).HasColumnName("TrustCompaniesHoldProp");
			this.Property(t => t.FinanceCompaniesHoldProp).HasColumnName("FinanceCompaniesHoldProp");
			this.Property(t => t.OtherInstitutionHoldProp).HasColumnName("OtherInstitutionHoldProp");
			this.Property(t => t.InstitutionsHoldingsA).HasColumnName("InstitutionsHoldingsA");
			this.Property(t => t.FundsHoldingsA).HasColumnName("FundsHoldingsA");
			this.Property(t => t.SecuritiesCorpsHoldingsA).HasColumnName("SecuritiesCorpsHoldingsA");
			this.Property(t => t.FinanceProductsHoldingsA).HasColumnName("FinanceProductsHoldingsA");
			this.Property(t => t.QFIIHoldingsA).HasColumnName("QFIIHoldingsA");
			this.Property(t => t.InsuranceCorpsHoldingsA).HasColumnName("InsuranceCorpsHoldingsA");
			this.Property(t => t.SocialSecurityFundHoldA).HasColumnName("SocialSecurityFundHoldA");
			this.Property(t => t.EnterpriseAnnuitiesHoldA).HasColumnName("EnterpriseAnnuitiesHoldA");
			this.Property(t => t.TrustCompaniesHoldingsA).HasColumnName("TrustCompaniesHoldingsA");
			this.Property(t => t.FinanceCompHoldingsA).HasColumnName("FinanceCompHoldingsA");
			this.Property(t => t.OtherInstiHoldingsA).HasColumnName("OtherInstiHoldingsA");
			this.Property(t => t.InstitutionsHoldPropA).HasColumnName("InstitutionsHoldPropA");
			this.Property(t => t.FundsHoldPropA).HasColumnName("FundsHoldPropA");
			this.Property(t => t.SecuritiesCorpsHoldPropA).HasColumnName("SecuritiesCorpsHoldPropA");
			this.Property(t => t.FinanceProductsHoldPropA).HasColumnName("FinanceProductsHoldPropA");
			this.Property(t => t.QFIIHoldPropA).HasColumnName("QFIIHoldPropA");
			this.Property(t => t.InsuranceCorpsHoldPropA).HasColumnName("InsuranceCorpsHoldPropA");
			this.Property(t => t.SocialSecuFundHoldPropA).HasColumnName("SocialSecuFundHoldPropA");
			this.Property(t => t.CorpAnnuitiesHoldPropA).HasColumnName("CorpAnnuitiesHoldPropA");
			this.Property(t => t.TrustCompaniesHoldPropA).HasColumnName("TrustCompaniesHoldPropA");
			this.Property(t => t.FinanceCompHoldPropA).HasColumnName("FinanceCompHoldPropA");
			this.Property(t => t.OtherInstiHoldPropA).HasColumnName("OtherInstiHoldPropA");
			this.Property(t => t.InstitutionsHoldingsT).HasColumnName("InstitutionsHoldingsT");
			this.Property(t => t.FundsHoldingsT).HasColumnName("FundsHoldingsT");
			this.Property(t => t.SecuritiesCorpsHoldingsT).HasColumnName("SecuritiesCorpsHoldingsT");
			this.Property(t => t.FinanceProductsHoldingsT).HasColumnName("FinanceProductsHoldingsT");
			this.Property(t => t.QFIIHoldingsT).HasColumnName("QFIIHoldingsT");
			this.Property(t => t.InsuranceCorpsHoldingsT).HasColumnName("InsuranceCorpsHoldingsT");
			this.Property(t => t.SocialSecurityFundHoldT).HasColumnName("SocialSecurityFundHoldT");
			this.Property(t => t.EnterpriseAnnuitiesHoldT).HasColumnName("EnterpriseAnnuitiesHoldT");
			this.Property(t => t.TrustCompaniesHoldingsT).HasColumnName("TrustCompaniesHoldingsT");
			this.Property(t => t.FinanceCompHoldingsT).HasColumnName("FinanceCompHoldingsT");
			this.Property(t => t.OtherInstiHoldingsT).HasColumnName("OtherInstiHoldingsT");
			this.Property(t => t.InstitutionsHoldPropT).HasColumnName("InstitutionsHoldPropT");
			this.Property(t => t.FundsHoldPropT).HasColumnName("FundsHoldPropT");
			this.Property(t => t.SecuritiesCorpsHoldPropT).HasColumnName("SecuritiesCorpsHoldPropT");
			this.Property(t => t.FinanceProductsHoldPropT).HasColumnName("FinanceProductsHoldPropT");
			this.Property(t => t.QFIIHoldPropT).HasColumnName("QFIIHoldPropT");
			this.Property(t => t.InsuranceCorpsHoldPropT).HasColumnName("InsuranceCorpsHoldPropT");
			this.Property(t => t.SocialSecuFundHoldPropT).HasColumnName("SocialSecuFundHoldPropT");
			this.Property(t => t.CorpAnnuitiesHoldPropT).HasColumnName("CorpAnnuitiesHoldPropT");
			this.Property(t => t.TrustCompaniesHoldPropT).HasColumnName("TrustCompaniesHoldPropT");
			this.Property(t => t.FinanceCompHoldPropT).HasColumnName("FinanceCompHoldPropT");
			this.Property(t => t.OtherInstiHoldPropT).HasColumnName("OtherInstiHoldPropT");
			this.Property(t => t.Top10StockholdersAmount).HasColumnName("Top10StockholdersAmount");
			this.Property(t => t.Top10StockholdersProp).HasColumnName("Top10StockholdersProp");
			this.Property(t => t.Top10NRStockholdersAmount).HasColumnName("Top10NRStockholdersAmount");
			this.Property(t => t.Top10NRHoldersAmountToNRS).HasColumnName("Top10NRHoldersAmountToNRS");
			this.Property(t => t.Top10NRHoldersAmountToTS).HasColumnName("Top10NRHoldersAmountToTS");
			this.Property(t => t.NRAFromTop10NRHolders).HasColumnName("NRAFromTop10NRHolders");
			this.Property(t => t.NRAFromTop10ToNRA).HasColumnName("NRAFromTop10ToNRA");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

