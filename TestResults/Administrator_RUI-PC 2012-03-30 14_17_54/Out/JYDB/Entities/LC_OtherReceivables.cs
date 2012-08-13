using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_OtherReceivables
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> Amount0_1 { get; set; }
		public Nullable<decimal> BadDebtProvision0_1 { get; set; }
		public Nullable<decimal> Amount1_2 { get; set; }
		public Nullable<decimal> BadDebtProvision1_2 { get; set; }
		public Nullable<decimal> Amount2_3 { get; set; }
		public Nullable<decimal> BadDebtProvision2_3 { get; set; }
		public Nullable<decimal> Amount3 { get; set; }
		public Nullable<decimal> BadDebtProvision3 { get; set; }
		public Nullable<decimal> Amount3_4 { get; set; }
		public Nullable<decimal> BadDebtProvision3_4 { get; set; }
		public Nullable<decimal> Amount4_5 { get; set; }
		public Nullable<decimal> BadDebtProvision4_5 { get; set; }
		public Nullable<decimal> Amount5 { get; set; }
		public Nullable<decimal> BadDebtProvision5 { get; set; }
		public Nullable<decimal> TotalAmount { get; set; }
		public Nullable<decimal> TotalBadDebtProvision { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> Proportion0_1 { get; set; }
		public Nullable<decimal> Proportion1_2 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp1_2 { get; set; }
		public Nullable<decimal> Proportion2_3 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp2_3 { get; set; }
		public Nullable<decimal> Proportion3 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp3 { get; set; }
		public Nullable<decimal> Proportion3_4 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp3_4 { get; set; }
		public Nullable<decimal> Proportion4_5 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp4_5 { get; set; }
		public Nullable<decimal> Proportion5 { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp5 { get; set; }
		public Nullable<decimal> ReserveWithdrawalPropT { get; set; }
		public Nullable<decimal> AmountSignificantSingle { get; set; }
		public Nullable<decimal> PropSignificantSingle { get; set; }
		public Nullable<decimal> BadDebtProvisionSS { get; set; }
		public Nullable<decimal> ReserveWithdrawalPropSS { get; set; }
		public Nullable<decimal> AmountCreditRiskHigh { get; set; }
		public Nullable<decimal> PropCreditRiskHigh { get; set; }
		public Nullable<decimal> BadDebtProvisionCRH { get; set; }
		public Nullable<decimal> ReserveWithdrawalPropCRH { get; set; }
		public Nullable<decimal> AmountInsignificant { get; set; }
		public Nullable<decimal> PropInsignificant { get; set; }
		public Nullable<decimal> BadDebtProvisionIS { get; set; }
		public Nullable<decimal> ReserveWithdrawalPropIS { get; set; }
		public Nullable<int> Mark { get; set; }
		public Nullable<decimal> ReserveWithdrawalProp0_1 { get; set; }
		public Nullable<decimal> AmountFromMainArrears { get; set; }
		public Nullable<decimal> RatioFromMainArrears { get; set; }
		public Nullable<decimal> AmountOfMainHolders { get; set; }
		public Nullable<decimal> RatioOfMainHolders { get; set; }
		public Nullable<decimal> AmountForRelations { get; set; }
		public Nullable<decimal> RatioForRelations { get; set; }
	}
}

