using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_RetailPriceIndex
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> RPICommodityRetail { get; set; }
		public Nullable<decimal> RPIFood { get; set; }
		public Nullable<decimal> RPIGrains { get; set; }
		public Nullable<decimal> RPIMeatPoultryEggs { get; set; }
		public Nullable<decimal> RPIFishandSeaFood { get; set; }
		public Nullable<decimal> RPIVegetables { get; set; }
		public Nullable<decimal> RPIDinningIdustry { get; set; }
		public Nullable<decimal> RPITobaccoandWines { get; set; }
		public Nullable<decimal> RPIClothingsShoesCaps { get; set; }
		public Nullable<decimal> RPITextiles { get; set; }
		public Nullable<decimal> RPIHomeElectricalAVM { get; set; }
		public Nullable<decimal> RPICulturalOffice { get; set; }
		public Nullable<decimal> RPIDailyNecessities { get; set; }
		public Nullable<decimal> RPISportEntertainment { get; set; }
		public Nullable<decimal> RPITrafficTelecom { get; set; }
		public Nullable<decimal> RPIFurniture { get; set; }
		public Nullable<decimal> RPICosmetic { get; set; }
		public Nullable<decimal> RPIGoldSilverJewelry { get; set; }
		public Nullable<decimal> RPIMedicinesHealthProducts { get; set; }
		public Nullable<decimal> RPIBookElecPublications { get; set; }
		public Nullable<decimal> RPIFuel { get; set; }
		public Nullable<decimal> RPIConstructionMetalsElec { get; set; }
		public Nullable<decimal> RPIAgriProductionMaterial { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

