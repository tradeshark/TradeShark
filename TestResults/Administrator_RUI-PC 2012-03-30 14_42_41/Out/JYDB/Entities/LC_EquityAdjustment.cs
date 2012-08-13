using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_EquityAdjustment
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> CurrencyUnit { get; set; }
		public Nullable<decimal> StoHolEquity_OAS { get; set; }
		public Nullable<decimal> LTEIDS { get; set; }
		public Nullable<decimal> SLTEIDS { get; set; }
		public Nullable<decimal> EECLTIA { get; set; }
		public Nullable<decimal> FVIH { get; set; }
		public Nullable<decimal> Depreciation { get; set; }
		public Nullable<decimal> ResignComp { get; set; }
		public Nullable<decimal> ShareTran { get; set; }
		public Nullable<decimal> ReorgDuty { get; set; }
		public Nullable<decimal> Merge { get; set; }
		public Nullable<decimal> GWAV { get; set; }
		public Nullable<decimal> GWR { get; set; }
		public Nullable<decimal> FVFASFA { get; set; }
		public Nullable<decimal> FVFD { get; set; }
		public Nullable<decimal> SFTII { get; set; }
		public Nullable<decimal> DFT { get; set; }
		public Nullable<decimal> Tax { get; set; }
		public Nullable<decimal> Other { get; set; }
		public Nullable<decimal> StoHolEquity_NAS { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> MinorityInterests { get; set; }
	}
}

