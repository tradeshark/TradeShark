using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SMAttendance
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> AnounceDate { get; set; }
		public Nullable<System.DateTime> MeetingDate { get; set; }
		public string Address { get; set; }
		public Nullable<int> MeetingType { get; set; }
		public Nullable<int> VotingMeans { get; set; }
		public string NetVotingCode { get; set; }
		public string VotingAbbr { get; set; }
		public string Presider { get; set; }
		public Nullable<int> PresiderOfficialPost { get; set; }
		public string TestmonyLawOffice { get; set; }
		public Nullable<int> LawOfficeCode { get; set; }
		public string Lawyer { get; set; }
		public Nullable<int> AttendanceType { get; set; }
		public Nullable<int> AttendanceNumber { get; set; }
		public Nullable<decimal> ShareReprensented { get; set; }
		public Nullable<decimal> RatioInTotalShare { get; set; }
		public Nullable<int> NTSHNumber { get; set; }
		public Nullable<int> ForeignNTSHNumber { get; set; }
		public Nullable<decimal> NTSHRepresentedShare { get; set; }
		public Nullable<decimal> FNTSHRepresentedShare { get; set; }
		public Nullable<int> TSHNumber { get; set; }
		public Nullable<int> ATSHNumber { get; set; }
		public Nullable<int> BTSHNumber { get; set; }
		public Nullable<int> HTSHNumber { get; set; }
		public Nullable<int> OtherTSHNumber { get; set; }
		public Nullable<decimal> TSHRepresentedShare { get; set; }
		public Nullable<decimal> ATSHRepresentedShare { get; set; }
		public Nullable<decimal> BTSHRepresentedShare { get; set; }
		public Nullable<decimal> HTSHRepresentedShare { get; set; }
		public Nullable<decimal> OtherTSHRepresentedShare { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> SMRegDate { get; set; }
	}
}

