using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Subsidy
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
		public Nullable<int> SubsidyTaxType { get; set; }
		public Nullable<decimal> SubsidySum { get; set; }
		public Nullable<decimal> ApportionTerm { get; set; }
		public Nullable<System.DateTime> SubsidyBeginDate { get; set; }
		public Nullable<System.DateTime> SunsidyEndDate { get; set; }
		public Nullable<decimal> LatestReceivedSubsidySum { get; set; }
		public Nullable<decimal> TotalReceivedSubsidySum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

