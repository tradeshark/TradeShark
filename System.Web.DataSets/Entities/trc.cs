using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class trc
	{
		public int RowNumber { get; set; }
		public Nullable<int> EventClass { get; set; }
		public string TextData { get; set; }
		public string ApplicationName { get; set; }
		public string NTUserName { get; set; }
		public string LoginName { get; set; }
		public Nullable<int> CPU { get; set; }
		public Nullable<long> Reads { get; set; }
		public Nullable<long> Writes { get; set; }
		public Nullable<long> Duration { get; set; }
		public Nullable<int> ClientProcessID { get; set; }
		public Nullable<int> SPID { get; set; }
		public Nullable<System.DateTime> StartTime { get; set; }
		public byte[] BinaryData { get; set; }
	}
}

