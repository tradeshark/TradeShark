using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_HGJCK_YDMap : EntityTypeConfiguration<VIEW_HG_HGJCK_YD>
	{
		public VIEW_HG_HGJCK_YDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.ReportPeriod, t.ReportArea, t.XGRQ });

			// Properties
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SovereigntyCountry)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ImExCountry)
				.HasMaxLength(300);
				
			this.Property(t => t.N_GoodsClassification)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Commodity)
				.HasMaxLength(50);
				
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_HGJCK_YD");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.N_SovereigntyCountry).HasColumnName("N_SovereigntyCountry");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_ImExCountry).HasColumnName("N_ImExCountry");
			this.Property(t => t.N_GoodsClassification).HasColumnName("N_GoodsClassification");
			this.Property(t => t.N_Commodity).HasColumnName("N_Commodity");
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
			this.Property(t => t.JCKCE1).HasColumnName("JCKCE1");
			this.Property(t => t.JCKCE2).HasColumnName("JCKCE2");
			this.Property(t => t.JCKCE3).HasColumnName("JCKCE3");
			this.Property(t => t.JCKCE4).HasColumnName("JCKCE4");
			this.Property(t => t.JCKCE5).HasColumnName("JCKCE5");
			this.Property(t => t.JCKCE6).HasColumnName("JCKCE6");
			this.Property(t => t.JCKCE7).HasColumnName("JCKCE7");
			this.Property(t => t.JCKCE8).HasColumnName("JCKCE8");
			this.Property(t => t.JCKCE9).HasColumnName("JCKCE9");
			this.Property(t => t.JCKCE10).HasColumnName("JCKCE10");
			this.Property(t => t.JCKCE11).HasColumnName("JCKCE11");
			this.Property(t => t.JCKCE12).HasColumnName("JCKCE12");
			this.Property(t => t.JCKCE13).HasColumnName("JCKCE13");
			this.Property(t => t.JCKCE14).HasColumnName("JCKCE14");
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
			this.Property(t => t.EXPR1).HasColumnName("EXPR1");
			this.Property(t => t.EXPR2).HasColumnName("EXPR2");
			this.Property(t => t.EXPR3).HasColumnName("EXPR3");
			this.Property(t => t.EXPR4).HasColumnName("EXPR4");
			this.Property(t => t.EXPR5).HasColumnName("EXPR5");
			this.Property(t => t.EXPR6).HasColumnName("EXPR6");
			this.Property(t => t.EXPR7).HasColumnName("EXPR7");
			this.Property(t => t.EXPR8).HasColumnName("EXPR8");
			this.Property(t => t.EXPR9).HasColumnName("EXPR9");
			this.Property(t => t.EXPR10).HasColumnName("EXPR10");
			this.Property(t => t.EXPR11).HasColumnName("EXPR11");
			this.Property(t => t.EXPR12).HasColumnName("EXPR12");
			this.Property(t => t.EXPR13).HasColumnName("EXPR13");
			this.Property(t => t.EXPR14).HasColumnName("EXPR14");
			this.Property(t => t.EXPR15).HasColumnName("EXPR15");
			this.Property(t => t.EXPR16).HasColumnName("EXPR16");
			this.Property(t => t.EXPR17).HasColumnName("EXPR17");
			this.Property(t => t.EXPR18).HasColumnName("EXPR18");
			this.Property(t => t.EXPR19).HasColumnName("EXPR19");
			this.Property(t => t.EXPR20).HasColumnName("EXPR20");
			this.Property(t => t.EXPR21).HasColumnName("EXPR21");
			this.Property(t => t.EXPR22).HasColumnName("EXPR22");
			this.Property(t => t.EXPR23).HasColumnName("EXPR23");
			this.Property(t => t.EXPR24).HasColumnName("EXPR24");
		}
	}
}

