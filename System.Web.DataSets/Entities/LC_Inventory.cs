using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_Inventory
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DataType { get; set; }
		public Nullable<decimal> RawMaterial { get; set; }
		public Nullable<decimal> InventoryInTransit { get; set; }
		public Nullable<decimal> DeveProduct { get; set; }
		public Nullable<decimal> ConstructingDeveProduct { get; set; }
		public Nullable<decimal> LeasingDeveProduct { get; set; }
		public Nullable<decimal> DeveCost { get; set; }
		public Nullable<decimal> UndeveLand { get; set; }
		public Nullable<decimal> ConstructionProject { get; set; }
		public Nullable<decimal> InventoryProducts { get; set; }
		public Nullable<decimal> SemiFinishedGoods { get; set; }
		public Nullable<decimal> WorkInProcessGoods { get; set; }
		public Nullable<decimal> FinishedGoods { get; set; }
		public Nullable<decimal> LowCostAndShortLivedArticles { get; set; }
		public Nullable<decimal> GoodsOnInstallmentSales { get; set; }
		public Nullable<decimal> GoodsInConsignors { get; set; }
		public Nullable<decimal> GoodsPurchased { get; set; }
		public Nullable<decimal> Fuel { get; set; }
		public Nullable<decimal> Containers { get; set; }
		public Nullable<decimal> MaterialsInConsignors { get; set; }
		public Nullable<decimal> MaterialsPurchased { get; set; }
		public Nullable<decimal> CostVariancesOfMaterials { get; set; }
		public Nullable<decimal> SpareParts { get; set; }
		public Nullable<decimal> FlightSpareParts { get; set; }
		public Nullable<decimal> ExpensiveTurnoverParts { get; set; }
		public Nullable<decimal> CommonEquipment { get; set; }
		public Nullable<decimal> OtherInventory { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

