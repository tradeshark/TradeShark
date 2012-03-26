using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class HK_StockArchives
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public Nullable<int> RegAbbr { get; set; }
		public string Business { get; set; }
		public Nullable<int> InduCHKE { get; set; }
		public Nullable<int> InduCHS { get; set; }
		public string Chairman { get; set; }
		public string CompanySecretary { get; set; }
		public string CertifiedAccountant { get; set; }
		public string RegisteredOffice { get; set; }
		public string GeneralOffice { get; set; }
		public string Registrars { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string Eail { get; set; }
		public string Website { get; set; }
		public string BriefIntroduction { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> CompanyType { get; set; }
		public string CompanyTypeDesc { get; set; }
		public string ChiName { get; set; }
		public string AuditInstitution { get; set; }
		public Nullable<decimal> RegCapital { get; set; }
		public Nullable<int> RegCapitalCurrency { get; set; }
	}
}

