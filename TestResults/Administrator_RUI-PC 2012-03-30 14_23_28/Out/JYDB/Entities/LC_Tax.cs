using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Tax
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> VATRate { get; set; }
		public string VATNote { get; set; }
		public Nullable<decimal> SalesTaxRateCeiling { get; set; }
		public Nullable<decimal> SalesTaxRateFloor { get; set; }
		public string SalesTaxNote { get; set; }
		public Nullable<decimal> CityPlanningTaxRate { get; set; }
		public string CityPlanningTaxNote { get; set; }
		public Nullable<decimal> EducationSurTaxRate { get; set; }
		public string EducationSurTaxNote { get; set; }
		public Nullable<decimal> EnterpriseIncomeTaxRate { get; set; }
		public Nullable<decimal> RefundRatio { get; set; }
		public Nullable<decimal> ActualRate { get; set; }
		public string EITaxNote { get; set; }
		public Nullable<decimal> HousePropertyTaxRate { get; set; }
		public string HousePropertyTaxNote { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

