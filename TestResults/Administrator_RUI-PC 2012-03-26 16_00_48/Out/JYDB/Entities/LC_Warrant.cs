using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Warrant
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AnnouncementType { get; set; }
		public Nullable<int> DisclosureMethod { get; set; }
		public string EventContent { get; set; }
		public string ActionDesc { get; set; }
		public string NewestAdvance { get; set; }
		public Nullable<int> EventSubject { get; set; }
		public Nullable<int> EventProcedure { get; set; }
		public Nullable<int> ActionWays { get; set; }
		public Nullable<int> CurrencyUnit { get; set; }
		public string SubjectName { get; set; }
		public Nullable<int> SubjectCode { get; set; }
		public Nullable<int> SubjectAssociation { get; set; }
		public string ObjectName { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> ObjectAssociation { get; set; }
		public Nullable<System.DateTime> AgreementDate { get; set; }
		public Nullable<int> IfEnded { get; set; }
		public string Note { get; set; }
		public Nullable<int> GuaranteeReason { get; set; }
		public Nullable<decimal> FirstGuaranteeSum { get; set; }
		public Nullable<decimal> LatestGuaranteeSum { get; set; }
		public string GuarantorCompany { get; set; }
		public Nullable<int> GuarantorAssociation { get; set; }
		public string GuaranteeAsset { get; set; }
		public string SecuredParty { get; set; }
		public Nullable<int> SecuredPartyAssociation { get; set; }
		public string CounterGuarantor { get; set; }
		public Nullable<int> CGuarantorAssociation { get; set; }
		public string CGuaranteeAsset { get; set; }
		public string LendBank { get; set; }
		public Nullable<decimal> LendTerm { get; set; }
		public Nullable<decimal> RenewalTerm { get; set; }
		public Nullable<System.DateTime> LendBeginDate { get; set; }
		public Nullable<System.DateTime> LendEndDate { get; set; }
		public Nullable<decimal> GuaranteeTerm { get; set; }
		public Nullable<decimal> RenewalGuaranteeTerm { get; set; }
		public Nullable<System.DateTime> GuaranteeBeginDate { get; set; }
		public Nullable<System.DateTime> GuaranteeEndDate { get; set; }
		public Nullable<System.DateTime> DischargeGuaranteeDate { get; set; }
		public Nullable<int> DischargeGuaranteeWays { get; set; }
		public Nullable<int> IfIllegality { get; set; }
		public Nullable<int> IfOverdue { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

