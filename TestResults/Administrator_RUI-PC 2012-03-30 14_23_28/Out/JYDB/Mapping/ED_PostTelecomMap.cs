using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_PostTelecomMap : EntityTypeConfiguration<ED_PostTelecom>
	{
		public ED_PostTelecomMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_PostTelecom");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.TotalPostTelecomBizVolume).HasColumnName("TotalPostTelecomBizVolume");
			this.Property(t => t.TotalPTBizVolumeGYoY).HasColumnName("TotalPTBizVolumeGYoY");
			this.Property(t => t.TotalPostBizVolume).HasColumnName("TotalPostBizVolume");
			this.Property(t => t.TotalPBizVolumeGYoY).HasColumnName("TotalPBizVolumeGYoY");
			this.Property(t => t.TotalTelecomBizVolume).HasColumnName("TotalTelecomBizVolume");
			this.Property(t => t.TotalTBizVolumeGYoY).HasColumnName("TotalTBizVolumeGYoY");
			this.Property(t => t.TotalPostTelecomBizIncome).HasColumnName("TotalPostTelecomBizIncome");
			this.Property(t => t.TotalPTBizIncomeGYoY).HasColumnName("TotalPTBizIncomeGYoY");
			this.Property(t => t.TotalPostBizIncome).HasColumnName("TotalPostBizIncome");
			this.Property(t => t.TotalPBizIncomeGYoY).HasColumnName("TotalPBizIncomeGYoY");
			this.Property(t => t.TotalTelecomBizIncome).HasColumnName("TotalTelecomBizIncome");
			this.Property(t => t.TotalTBizIncomeGYoY).HasColumnName("TotalTBizIncomeGYoY");
			this.Property(t => t.TotalFAInv).HasColumnName("TotalFAInv");
			this.Property(t => t.TotalFAInvGYoY).HasColumnName("TotalFAInvGYoY");
			this.Property(t => t.TotalPostBizFAInv).HasColumnName("TotalPostBizFAInv");
			this.Property(t => t.TotalPostBizFAInvGYoY).HasColumnName("TotalPostBizFAInvGYoY");
			this.Property(t => t.TotalTelecomBizFAInv).HasColumnName("TotalTelecomBizFAInv");
			this.Property(t => t.TotalTelecomBizFAInvGYoY).HasColumnName("TotalTelecomBizFAInvGYoY");
			this.Property(t => t.OpticalCableLength).HasColumnName("OpticalCableLength");
			this.Property(t => t.LongDistanceOCLength).HasColumnName("LongDistanceOCLength");
			this.Property(t => t.RelayOCLengthLocalNetwork).HasColumnName("RelayOCLengthLocalNetwork");
			this.Property(t => t.DigitalMicrowaveLength).HasColumnName("DigitalMicrowaveLength");
			this.Property(t => t.LDCallSwitchCapacity).HasColumnName("LDCallSwitchCapacity");
			this.Property(t => t.LDBizCircuits).HasColumnName("LDBizCircuits");
			this.Property(t => t.LocalSwitcherCapacity).HasColumnName("LocalSwitcherCapacity");
			this.Property(t => t.AccessEquipmentCapacity).HasColumnName("AccessEquipmentCapacity");
			this.Property(t => t.UserSwitcherCapacity).HasColumnName("UserSwitcherCapacity");
			this.Property(t => t.WirelessSwitcherCapacity).HasColumnName("WirelessSwitcherCapacity");
			this.Property(t => t.TotalLetters).HasColumnName("TotalLetters");
			this.Property(t => t.TotalLettersGYoY).HasColumnName("TotalLettersGYoY");
			this.Property(t => t.Parcel).HasColumnName("Parcel");
			this.Property(t => t.ParcelGYoY).HasColumnName("ParcelGYoY");
			this.Property(t => t.Remittance).HasColumnName("Remittance");
			this.Property(t => t.NewpaperSubscription).HasColumnName("NewpaperSubscription");
			this.Property(t => t.MagazineSubscription).HasColumnName("MagazineSubscription");
			this.Property(t => t.StampCollection).HasColumnName("StampCollection");
			this.Property(t => t.PostSavingsPeriodEnd).HasColumnName("PostSavingsPeriodEnd");
			this.Property(t => t.PostSavingsPeriodEndGYoY).HasColumnName("PostSavingsPeriodEndGYoY");
			this.Property(t => t.MinutesLDCalls).HasColumnName("MinutesLDCalls");
			this.Property(t => t.MinutesLDCallsGYoY).HasColumnName("MinutesLDCallsGYoY");
			this.Property(t => t.MinutesDLDCalls).HasColumnName("MinutesDLDCalls");
			this.Property(t => t.MinutesILDCalls).HasColumnName("MinutesILDCalls");
			this.Property(t => t.MinutesHKMCTWLDCalls).HasColumnName("MinutesHKMCTWLDCalls");
			this.Property(t => t.MinutesWirelessLocalCall).HasColumnName("MinutesWirelessLocalCall");
			this.Property(t => t.MinutesWirelessDLDCalls).HasColumnName("MinutesWirelessDLDCalls");
			this.Property(t => t.MinutesWirelessILDCalls).HasColumnName("MinutesWirelessILDCalls");
			this.Property(t => t.MinutesWirelessHKMCTWLDCalls).HasColumnName("MinutesWirelessHKMCTWLDCalls");
			this.Property(t => t.MinutesDomesticIPCalls).HasColumnName("MinutesDomesticIPCalls");
			this.Property(t => t.MinutesIntlIPCalls).HasColumnName("MinutesIntlIPCalls");
			this.Property(t => t.MinutesHKMCTWIPCalls).HasColumnName("MinutesHKMCTWIPCalls");
			this.Property(t => t.LNInterRegionCallVolumes).HasColumnName("LNInterRegionCallVolumes");
			this.Property(t => t.LNIntraRegionCallVolumes).HasColumnName("LNIntraRegionCallVolumes");
			this.Property(t => t.LNDialupCallVolumes).HasColumnName("LNDialupCallVolumes");
			this.Property(t => t.FixedLineUsers).HasColumnName("FixedLineUsers");
			this.Property(t => t.FixedLineUsersGYoY).HasColumnName("FixedLineUsersGYoY");
			this.Property(t => t.UrbanPhoneUsers).HasColumnName("UrbanPhoneUsers");
			this.Property(t => t.UrbanPhoneUsersGYoY).HasColumnName("UrbanPhoneUsersGYoY");
			this.Property(t => t.RuralPhoneUsers).HasColumnName("RuralPhoneUsers");
			this.Property(t => t.RuralPhoneUsersGYoY).HasColumnName("RuralPhoneUsersGYoY");
			this.Property(t => t.UrbanResidentPhoneUsers).HasColumnName("UrbanResidentPhoneUsers");
			this.Property(t => t.RuralResidentPhoneUsers).HasColumnName("RuralResidentPhoneUsers");
			this.Property(t => t.MobileUsers).HasColumnName("MobileUsers");
			this.Property(t => t.MobileUsersGYoY).HasColumnName("MobileUsersGYoY");
			this.Property(t => t.BeeperUsers).HasColumnName("BeeperUsers");
			this.Property(t => t.BeeperUsersGYoY).HasColumnName("BeeperUsersGYoY");
			this.Property(t => t.DataServicesUsers).HasColumnName("DataServicesUsers");
			this.Property(t => t.InternetUsers).HasColumnName("InternetUsers");
			this.Property(t => t.InternetDialupUsers).HasColumnName("InternetDialupUsers");
			this.Property(t => t.InternetSpecialLineUsers).HasColumnName("InternetSpecialLineUsers");
			this.Property(t => t.PostSavingsMarketShare).HasColumnName("PostSavingsMarketShare");
			this.Property(t => t.MainLinePenetrationRate).HasColumnName("MainLinePenetrationRate");
			this.Property(t => t.UrbanMainLinePRate).HasColumnName("UrbanMainLinePRate");
			this.Property(t => t.TelephonePRate).HasColumnName("TelephonePRate");
			this.Property(t => t.FixedLinePRate).HasColumnName("FixedLinePRate");
			this.Property(t => t.UrbanTelephonePRate).HasColumnName("UrbanTelephonePRate");
			this.Property(t => t.MobilePhonePRate).HasColumnName("MobilePhonePRate");
			this.Property(t => t.PhoneConnectedVillageRatio).HasColumnName("PhoneConnectedVillageRatio");
			this.Property(t => t.PhoneAvaiableVillageRatio).HasColumnName("PhoneAvaiableVillageRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

