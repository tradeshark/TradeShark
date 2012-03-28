using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_GP_GQBD
	{
		public string N_TranMode { get; set; }
		public string N_TranShareType { get; set; }
		public string N_IfSuspended { get; set; }
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> ContractSignDate { get; set; }
		public Nullable<System.DateTime> ApprovedDate { get; set; }
		public Nullable<System.DateTime> TranDate { get; set; }
		public string TransfererName { get; set; }
		public Nullable<int> TansfererEcoNature { get; set; }
		public Nullable<int> TranShareType { get; set; }
		public Nullable<decimal> SumBeforeTran { get; set; }
		public Nullable<decimal> PCTBeforeTran { get; set; }
		public Nullable<decimal> SumAfterTran { get; set; }
		public Nullable<decimal> PCTAfterTran { get; set; }
		public string ReceiverName { get; set; }
		public Nullable<int> ReceiverEcoNature { get; set; }
		public Nullable<decimal> SumAfterRece { get; set; }
		public Nullable<decimal> PCTAfterRece { get; set; }
		public Nullable<int> TranMode { get; set; }
		public Nullable<decimal> InvolvedSum { get; set; }
		public Nullable<decimal> PCTOfTansferer { get; set; }
		public Nullable<decimal> PCTOfTotalShares { get; set; }
		public Nullable<decimal> DealPrice { get; set; }
		public Nullable<decimal> DealTurnover { get; set; }
		public string ValidCondition { get; set; }
		public string TranStatement { get; set; }
		public Nullable<int> IfSuspended { get; set; }
		public Nullable<System.DateTime> SuspendedPublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

