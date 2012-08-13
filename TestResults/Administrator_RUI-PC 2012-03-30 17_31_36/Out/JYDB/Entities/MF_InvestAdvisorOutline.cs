using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_InvestAdvisorOutline
	{
		public long ID { get; set; }
		public int InvestAdvisorCode { get; set; }
		public string InvestAdvisorName { get; set; }
		public string InvestAdvisorAbbrName { get; set; }
		public string LegalRepr { get; set; }
		public string GeneralManager { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public string OrganizationForm { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public string RegAddr { get; set; }
		public string OfficeAddr { get; set; }
		public string ZipCode { get; set; }
		public string Email { get; set; }
		public string ContactAddr { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string WebSite { get; set; }
		public string LinkMan { get; set; }
		public string Background { get; set; }
		public Nullable<int> Region { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public string ServiceLine { get; set; }
	}
}

