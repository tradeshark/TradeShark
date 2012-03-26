using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_ConsumerPriceIndex
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> CPI { get; set; }
		public Nullable<decimal> CPIFood { get; set; }
		public Nullable<decimal> CPIGrain { get; set; }
		public Nullable<decimal> CPIMeatPoultry { get; set; }
		public Nullable<decimal> CPIEgg { get; set; }
		public Nullable<decimal> CPIFishandSeaFood { get; set; }
		public Nullable<decimal> CPIVegetable { get; set; }
		public Nullable<decimal> CPIFruits { get; set; }
		public Nullable<decimal> CPIEatOut { get; set; }
		public Nullable<decimal> CPITobacco { get; set; }
		public Nullable<decimal> CPICloth { get; set; }
		public Nullable<decimal> CPIFamilyEquipmentService { get; set; }
		public Nullable<decimal> CPIMedicare { get; set; }
		public Nullable<decimal> CPITrafficCommunication { get; set; }
		public Nullable<decimal> CPIEntertainmentService { get; set; }
		public Nullable<decimal> CPIHousing { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

