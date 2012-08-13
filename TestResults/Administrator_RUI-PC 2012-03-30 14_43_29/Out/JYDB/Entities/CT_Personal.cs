using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_Personal
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> PersonalType { get; set; }
		public int PersonalNum { get; set; }
		public string PersonalName { get; set; }
		public string WorkPlace { get; set; }
		public Nullable<int> CompanyCode { get; set; }
		public string Gender { get; set; }
		public string BirthY { get; set; }
		public string Education { get; set; }
		public string ProfessionalTitle { get; set; }
		public string Tel { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string Background { get; set; }
		public string MajorName { get; set; }
		public string PositionName { get; set; }
		public string Remark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

