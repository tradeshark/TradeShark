using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ShareTrustee
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string Authorizer { get; set; }
		public Nullable<decimal> AuthorizerHoldSum { get; set; }
		public string AuthorizedReceiver { get; set; }
		public Nullable<decimal> InvolvedTrustSum { get; set; }
		public Nullable<decimal> PCTOfAuthorizer { get; set; }
		public Nullable<decimal> PCTOfFullShares { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string TrustStatement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

