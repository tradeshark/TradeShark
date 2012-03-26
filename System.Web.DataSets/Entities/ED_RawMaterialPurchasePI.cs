using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_RawMaterialPurchasePI
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> RMPPIAllRawMaterials { get; set; }
		public Nullable<decimal> RMPPIFuelsPower { get; set; }
		public Nullable<decimal> RMPPIFerrousMetalMaterials { get; set; }
		public Nullable<decimal> RMPPINonFerrousMetalMaterials { get; set; }
		public Nullable<decimal> RMPPIChemicalMaterials { get; set; }
		public Nullable<decimal> RMPPITimberPulp { get; set; }
		public Nullable<decimal> RMPPIConstructionMaterials { get; set; }
		public Nullable<decimal> RMPPIRawSemiFinishedGoods { get; set; }
		public Nullable<decimal> RMPPIAgriSidelineProducts { get; set; }
		public Nullable<decimal> RMPPIWeavingMaterials { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

