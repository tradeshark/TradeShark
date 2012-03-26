using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_InstiArchive
	{
		public long ID { get; set; }
		public Nullable<int> CompanyCode { get; set; }
		public Nullable<int> ParentCompany { get; set; }
		public Nullable<int> ListedCode { get; set; }
		public Nullable<int> InvestAdvisorName { get; set; }
		public Nullable<int> TrusteeName { get; set; }
		public string ChiName { get; set; }
		public string AbbrChiName { get; set; }
		public string NameChiSpelling { get; set; }
		public string EngName { get; set; }
		public string AbbrEngName { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public Nullable<int> CurrencyUnit { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public Nullable<int> EconomicNature { get; set; }
		public Nullable<int> CompanyNature { get; set; }
		public Nullable<int> CompanyType { get; set; }
		public string RegAddr { get; set; }
		public string RegZip { get; set; }
		public Nullable<int> RegCity { get; set; }
		public string OfficeAddr { get; set; }
		public string ContactAddr { get; set; }
		public string ContactZip { get; set; }
		public Nullable<int> ContactCity { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public string LegalPersonRepr { get; set; }
		public string GeneralManager { get; set; }
		public string OtherManager { get; set; }
		public string Contactman { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string BriefIntroText { get; set; }
		public string BusinessMajor { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> CloseDate { get; set; }
		public Nullable<int> CloseReason { get; set; }
		public Nullable<int> IfExisted { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

