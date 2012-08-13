using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_CorporateGoodsPI
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<decimal> CGPIGeneralIndex { get; set; }
		public Nullable<decimal> CGPIFarmProduct { get; set; }
		public Nullable<decimal> CGPIMineralProduct { get; set; }
		public Nullable<decimal> CGPICoalOilElectricity { get; set; }
		public Nullable<decimal> CGPIProcessedGoods { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

