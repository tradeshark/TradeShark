using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_PostTelecom
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> TotalPostTelecomBizVolume { get; set; }
		public Nullable<decimal> TotalPTBizVolumeGYoY { get; set; }
		public Nullable<decimal> TotalPostBizVolume { get; set; }
		public Nullable<decimal> TotalPBizVolumeGYoY { get; set; }
		public Nullable<decimal> TotalTelecomBizVolume { get; set; }
		public Nullable<decimal> TotalTBizVolumeGYoY { get; set; }
		public Nullable<decimal> TotalPostTelecomBizIncome { get; set; }
		public Nullable<decimal> TotalPTBizIncomeGYoY { get; set; }
		public Nullable<decimal> TotalPostBizIncome { get; set; }
		public Nullable<decimal> TotalPBizIncomeGYoY { get; set; }
		public Nullable<decimal> TotalTelecomBizIncome { get; set; }
		public Nullable<decimal> TotalTBizIncomeGYoY { get; set; }
		public Nullable<decimal> TotalFAInv { get; set; }
		public Nullable<decimal> TotalFAInvGYoY { get; set; }
		public Nullable<decimal> TotalPostBizFAInv { get; set; }
		public Nullable<decimal> TotalPostBizFAInvGYoY { get; set; }
		public Nullable<decimal> TotalTelecomBizFAInv { get; set; }
		public Nullable<decimal> TotalTelecomBizFAInvGYoY { get; set; }
		public Nullable<decimal> OpticalCableLength { get; set; }
		public Nullable<decimal> LongDistanceOCLength { get; set; }
		public Nullable<decimal> RelayOCLengthLocalNetwork { get; set; }
		public Nullable<decimal> DigitalMicrowaveLength { get; set; }
		public Nullable<decimal> LDCallSwitchCapacity { get; set; }
		public Nullable<decimal> LDBizCircuits { get; set; }
		public Nullable<decimal> LocalSwitcherCapacity { get; set; }
		public Nullable<decimal> AccessEquipmentCapacity { get; set; }
		public Nullable<decimal> UserSwitcherCapacity { get; set; }
		public Nullable<decimal> WirelessSwitcherCapacity { get; set; }
		public Nullable<decimal> TotalLetters { get; set; }
		public Nullable<decimal> TotalLettersGYoY { get; set; }
		public Nullable<decimal> Parcel { get; set; }
		public Nullable<decimal> ParcelGYoY { get; set; }
		public Nullable<decimal> Remittance { get; set; }
		public Nullable<decimal> NewpaperSubscription { get; set; }
		public Nullable<decimal> MagazineSubscription { get; set; }
		public Nullable<decimal> StampCollection { get; set; }
		public Nullable<decimal> PostSavingsPeriodEnd { get; set; }
		public Nullable<decimal> PostSavingsPeriodEndGYoY { get; set; }
		public Nullable<decimal> MinutesLDCalls { get; set; }
		public Nullable<decimal> MinutesLDCallsGYoY { get; set; }
		public Nullable<decimal> MinutesDLDCalls { get; set; }
		public Nullable<decimal> MinutesILDCalls { get; set; }
		public Nullable<decimal> MinutesHKMCTWLDCalls { get; set; }
		public Nullable<decimal> MinutesWirelessLocalCall { get; set; }
		public Nullable<decimal> MinutesWirelessDLDCalls { get; set; }
		public Nullable<decimal> MinutesWirelessILDCalls { get; set; }
		public Nullable<decimal> MinutesWirelessHKMCTWLDCalls { get; set; }
		public Nullable<decimal> MinutesDomesticIPCalls { get; set; }
		public Nullable<decimal> MinutesIntlIPCalls { get; set; }
		public Nullable<decimal> MinutesHKMCTWIPCalls { get; set; }
		public Nullable<decimal> LNInterRegionCallVolumes { get; set; }
		public Nullable<decimal> LNIntraRegionCallVolumes { get; set; }
		public Nullable<decimal> LNDialupCallVolumes { get; set; }
		public Nullable<decimal> FixedLineUsers { get; set; }
		public Nullable<decimal> FixedLineUsersGYoY { get; set; }
		public Nullable<decimal> UrbanPhoneUsers { get; set; }
		public Nullable<decimal> UrbanPhoneUsersGYoY { get; set; }
		public Nullable<decimal> RuralPhoneUsers { get; set; }
		public Nullable<decimal> RuralPhoneUsersGYoY { get; set; }
		public Nullable<decimal> UrbanResidentPhoneUsers { get; set; }
		public Nullable<decimal> RuralResidentPhoneUsers { get; set; }
		public Nullable<decimal> MobileUsers { get; set; }
		public Nullable<decimal> MobileUsersGYoY { get; set; }
		public Nullable<decimal> BeeperUsers { get; set; }
		public Nullable<decimal> BeeperUsersGYoY { get; set; }
		public Nullable<decimal> DataServicesUsers { get; set; }
		public Nullable<decimal> InternetUsers { get; set; }
		public Nullable<decimal> InternetDialupUsers { get; set; }
		public Nullable<decimal> InternetSpecialLineUsers { get; set; }
		public Nullable<decimal> PostSavingsMarketShare { get; set; }
		public Nullable<decimal> MainLinePenetrationRate { get; set; }
		public Nullable<decimal> UrbanMainLinePRate { get; set; }
		public Nullable<decimal> TelephonePRate { get; set; }
		public Nullable<decimal> FixedLinePRate { get; set; }
		public Nullable<decimal> UrbanTelephonePRate { get; set; }
		public Nullable<decimal> MobilePhonePRate { get; set; }
		public Nullable<decimal> PhoneConnectedVillageRatio { get; set; }
		public Nullable<decimal> PhoneAvaiableVillageRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

