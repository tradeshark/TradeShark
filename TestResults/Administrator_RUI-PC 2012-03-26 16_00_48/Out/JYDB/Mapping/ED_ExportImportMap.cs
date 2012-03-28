using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ExportImportMap : EntityTypeConfiguration<ED_ExportImport>
	{
		public ED_ExportImportMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_ExportImport");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.SovereigntyCountry).HasColumnName("SovereigntyCountry");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.ImExCountry).HasColumnName("ImExCountry");
			this.Property(t => t.GoodsClassification).HasColumnName("GoodsClassification");
			this.Property(t => t.Commodity).HasColumnName("Commodity");
			this.Property(t => t.ExImValueOfGoods).HasColumnName("ExImValueOfGoods");
			this.Property(t => t.ExImValueOfGeneralTrade).HasColumnName("ExImValueOfGeneralTrade");
			this.Property(t => t.ExImValueOfProcessingTrade).HasColumnName("ExImValueOfProcessingTrade");
			this.Property(t => t.ExImValueOfProcessMaterial).HasColumnName("ExImValueOfProcessMaterial");
			this.Property(t => t.ExImValueOfImMaterial).HasColumnName("ExImValueOfImMaterial");
			this.Property(t => t.ExImValueOfOtherTrade).HasColumnName("ExImValueOfOtherTrade");
			this.Property(t => t.ExImValueOfSOE).HasColumnName("ExImValueOfSOE");
			this.Property(t => t.ExImValueOfFInvCom).HasColumnName("ExImValueOfFInvCom");
			this.Property(t => t.ExImValueOfJV).HasColumnName("ExImValueOfJV");
			this.Property(t => t.ExImValueOfSFCooperatives).HasColumnName("ExImValueOfSFCooperatives");
			this.Property(t => t.ExImValueOfWFOE).HasColumnName("ExImValueOfWFOE");
			this.Property(t => t.ExImValueOfCollectiveCom).HasColumnName("ExImValueOfCollectiveCom");
			this.Property(t => t.ExImValueOfPrivateCom).HasColumnName("ExImValueOfPrivateCom");
			this.Property(t => t.ExImValueOfOtherCom).HasColumnName("ExImValueOfOtherCom");
			this.Property(t => t.ExValueOfGoods).HasColumnName("ExValueOfGoods");
			this.Property(t => t.ExValueOfGeneralTrade).HasColumnName("ExValueOfGeneralTrade");
			this.Property(t => t.ExValueOfProcessingTrade).HasColumnName("ExValueOfProcessingTrade");
			this.Property(t => t.ExValueOfProcessMaterial).HasColumnName("ExValueOfProcessMaterial");
			this.Property(t => t.ExValueOfImMaterial).HasColumnName("ExValueOfImMaterial");
			this.Property(t => t.ExValueOfOtherTrade).HasColumnName("ExValueOfOtherTrade");
			this.Property(t => t.ExValueOfSOE).HasColumnName("ExValueOfSOE");
			this.Property(t => t.ExValueOfFInvCom).HasColumnName("ExValueOfFInvCom");
			this.Property(t => t.ExValueOfJV).HasColumnName("ExValueOfJV");
			this.Property(t => t.ExValueOfSFCooperatives).HasColumnName("ExValueOfSFCooperatives");
			this.Property(t => t.ExValueOfWFOE).HasColumnName("ExValueOfWFOE");
			this.Property(t => t.ExValueOfCollectiveCom).HasColumnName("ExValueOfCollectiveCom");
			this.Property(t => t.ExValueOfPrivateCom).HasColumnName("ExValueOfPrivateCom");
			this.Property(t => t.ExValueOfOtherCom).HasColumnName("ExValueOfOtherCom");
			this.Property(t => t.ImValueOfGoods).HasColumnName("ImValueOfGoods");
			this.Property(t => t.ImValueOfGeneralTrade).HasColumnName("ImValueOfGeneralTrade");
			this.Property(t => t.ImValueOfProcessingTrade).HasColumnName("ImValueOfProcessingTrade");
			this.Property(t => t.ImValueOfProcessMaterial).HasColumnName("ImValueOfProcessMaterial");
			this.Property(t => t.ImValueOfImMaterial).HasColumnName("ImValueOfImMaterial");
			this.Property(t => t.ImValueOfOtherTrade).HasColumnName("ImValueOfOtherTrade");
			this.Property(t => t.ImValueOfSOE).HasColumnName("ImValueOfSOE");
			this.Property(t => t.ImValueOfFInvCom).HasColumnName("ImValueOfFInvCom");
			this.Property(t => t.ImValueOfJV).HasColumnName("ImValueOfJV");
			this.Property(t => t.ImValueOfSFCooperatives).HasColumnName("ImValueOfSFCooperatives");
			this.Property(t => t.ImValueOfWFOE).HasColumnName("ImValueOfWFOE");
			this.Property(t => t.ImValueOfCollectiveCom).HasColumnName("ImValueOfCollectiveCom");
			this.Property(t => t.ImValueOfPrivateCom).HasColumnName("ImValueOfPrivateCom");
			this.Property(t => t.ImValueOfOtherCom).HasColumnName("ImValueOfOtherCom");
			this.Property(t => t.GYoYOfExImValueGoods).HasColumnName("GYoYOfExImValueGoods");
			this.Property(t => t.GYoYOfExImValueGT).HasColumnName("GYoYOfExImValueGT");
			this.Property(t => t.GYoYOfExImValuePT).HasColumnName("GYoYOfExImValuePT");
			this.Property(t => t.GYoYOfExImValuePM).HasColumnName("GYoYOfExImValuePM");
			this.Property(t => t.GYoYOfExImValueIM).HasColumnName("GYoYOfExImValueIM");
			this.Property(t => t.GYoYOfExImValueOT).HasColumnName("GYoYOfExImValueOT");
			this.Property(t => t.GYoYOfExImValueSOE).HasColumnName("GYoYOfExImValueSOE");
			this.Property(t => t.GYoYOfExImValueFInvCom).HasColumnName("GYoYOfExImValueFInvCom");
			this.Property(t => t.GYoYOfExImValueJV).HasColumnName("GYoYOfExImValueJV");
			this.Property(t => t.GYoYOfExImValueSFC).HasColumnName("GYoYOfExImValueSFC");
			this.Property(t => t.GYoYOfExImValueWFOE).HasColumnName("GYoYOfExImValueWFOE");
			this.Property(t => t.GYoYOfExImValueCC).HasColumnName("GYoYOfExImValueCC");
			this.Property(t => t.GYoYOfExImValuePC).HasColumnName("GYoYOfExImValuePC");
			this.Property(t => t.GYoYOfExImValueOC).HasColumnName("GYoYOfExImValueOC");
			this.Property(t => t.GYoYOfExValueGoods).HasColumnName("GYoYOfExValueGoods");
			this.Property(t => t.GYoYOfExValueGT).HasColumnName("GYoYOfExValueGT");
			this.Property(t => t.GYoYOfExValuePT).HasColumnName("GYoYOfExValuePT");
			this.Property(t => t.GYoYOfExValuePM).HasColumnName("GYoYOfExValuePM");
			this.Property(t => t.GYoYOfExValueIM).HasColumnName("GYoYOfExValueIM");
			this.Property(t => t.GYoYOfExValueOT).HasColumnName("GYoYOfExValueOT");
			this.Property(t => t.GYoYOfExValueSOE).HasColumnName("GYoYOfExValueSOE");
			this.Property(t => t.GYoYOfExValueFInvCom).HasColumnName("GYoYOfExValueFInvCom");
			this.Property(t => t.GYoYOfExValueJV).HasColumnName("GYoYOfExValueJV");
			this.Property(t => t.GYoYOfExValueSFC).HasColumnName("GYoYOfExValueSFC");
			this.Property(t => t.GYoYOfExValueWFOE).HasColumnName("GYoYOfExValueWFOE");
			this.Property(t => t.GYoYOfExValueCC).HasColumnName("GYoYOfExValueCC");
			this.Property(t => t.GYoYOfExValuePC).HasColumnName("GYoYOfExValuePC");
			this.Property(t => t.GYoYOfExValueOC).HasColumnName("GYoYOfExValueOC");
			this.Property(t => t.GYoYOfImValueGoods).HasColumnName("GYoYOfImValueGoods");
			this.Property(t => t.GYoYOfImValueGT).HasColumnName("GYoYOfImValueGT");
			this.Property(t => t.GYoYOfImValuePT).HasColumnName("GYoYOfImValuePT");
			this.Property(t => t.GYoYOfImValuePM).HasColumnName("GYoYOfImValuePM");
			this.Property(t => t.GYoYOfImValueIM).HasColumnName("GYoYOfImValueIM");
			this.Property(t => t.GYoYOfImValueOT).HasColumnName("GYoYOfImValueOT");
			this.Property(t => t.GYoYOfImValueSOE).HasColumnName("GYoYOfImValueSOE");
			this.Property(t => t.GYoYOfImValueFInvCom).HasColumnName("GYoYOfImValueFInvCom");
			this.Property(t => t.GYoYOfImValueJV).HasColumnName("GYoYOfImValueJV");
			this.Property(t => t.GYoYOfImValueSFC).HasColumnName("GYoYOfImValueSFC");
			this.Property(t => t.GYoYOfImValueWFOE).HasColumnName("GYoYOfImValueWFOE");
			this.Property(t => t.GYoYOfImValueCC).HasColumnName("GYoYOfImValueCC");
			this.Property(t => t.GYoYOfImValuePC).HasColumnName("GYoYOfImValuePC");
			this.Property(t => t.GYoYOfImValueOC).HasColumnName("GYoYOfImValueOC");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ExImBalance).HasColumnName("ExImBalance");
			this.Property(t => t.ExImBalanceYOY).HasColumnName("ExImBalanceYOY");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

