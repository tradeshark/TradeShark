using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SuitArbitration
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
		public Nullable<decimal> FirstSuitSum { get; set; }
		public Nullable<decimal> LatestSuitSum { get; set; }
		public string Plaintiff { get; set; }
		public Nullable<int> PlaintiffAssociation { get; set; }
		public string Defendant { get; set; }
		public Nullable<int> DefendantAssociation { get; set; }
		public string JSRParty { get; set; }
		public Nullable<int> JSRPartyAssociation { get; set; }
		public string OtherParty { get; set; }
		public Nullable<int> OtherPartyAssociation { get; set; }
		public string SubjectMatterStat { get; set; }
		public Nullable<int> SubjectMatter { get; set; }
		public Nullable<int> EventSubjectRole { get; set; }
		public string InquisitionInstitute { get; set; }
		public Nullable<int> CaseStatus { get; set; }
		public Nullable<int> FirstInstanceStatus { get; set; }
		public Nullable<int> SecondInstanceStatus { get; set; }
		public Nullable<int> SPPStatus { get; set; }
		public Nullable<int> PropertyEnforcement { get; set; }
		public string PropertyEnforced { get; set; }
		public Nullable<int> PropertyBelonged { get; set; }
		public Nullable<int> AdjudgementStatus { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

