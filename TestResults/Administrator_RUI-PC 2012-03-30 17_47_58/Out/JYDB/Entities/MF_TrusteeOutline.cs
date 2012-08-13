using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_TrusteeOutline
	{
		public long ID { get; set; }
		public int TrusteeCode { get; set; }
		public string TrusteeName { get; set; }
		public string LegalRepr { get; set; }
		public string TrusteeFunctionary { get; set; }
		public string LinkMan { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public string OrganizationForm { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public string RegAddr { get; set; }
		public string OfficeAddr { get; set; }
		public string ZipCode { get; set; }
		public string WebSite { get; set; }
		public string Email { get; set; }
		public string ContactAddr { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string Background { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

