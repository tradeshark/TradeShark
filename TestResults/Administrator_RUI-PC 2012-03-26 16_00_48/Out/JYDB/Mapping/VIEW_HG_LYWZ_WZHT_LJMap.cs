using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_LYWZ_WZHT_LJMap : EntityTypeConfiguration<VIEW_HG_LYWZ_WZHT_LJ>
	{
		public VIEW_HG_LYWZ_WZHT_LJMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.ReportPeriod, t.ReportArea, t.XGRQ });

			// Properties
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Country)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Industry)
				.HasMaxLength(50);
				
			this.Property(t => t.N_FInvType)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_LYWZ_WZHT_LJ");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Country).HasColumnName("N_Country");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_Industry).HasColumnName("N_Industry");
			this.Property(t => t.N_FInvType).HasColumnName("N_FInvType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.FInvType).HasColumnName("FInvType");
			this.Property(t => t.TotalFInvValue).HasColumnName("TotalFInvValue");
			this.Property(t => t.FDI).HasColumnName("FDI");
			this.Property(t => t.JV).HasColumnName("JV");
			this.Property(t => t.SFCooperative).HasColumnName("SFCooperative");
			this.Property(t => t.WOFE).HasColumnName("WOFE");
			this.Property(t => t.FInvStockCompany).HasColumnName("FInvStockCompany");
			this.Property(t => t.JointDevelopment).HasColumnName("JointDevelopment");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.OtherForeignInvestment).HasColumnName("OtherForeignInvestment");
			this.Property(t => t.AbroadStockIssuance).HasColumnName("AbroadStockIssuance");
			this.Property(t => t.InternationalLease).HasColumnName("InternationalLease");
			this.Property(t => t.CompensatedTrade).HasColumnName("CompensatedTrade");
			this.Property(t => t.AssemblyProcessing).HasColumnName("AssemblyProcessing");
			this.Property(t => t.ForeignLoans).HasColumnName("ForeignLoans");
			this.Property(t => t.ForeignGovernmentLoans).HasColumnName("ForeignGovernmentLoans");
			this.Property(t => t.InternationalFILoans).HasColumnName("InternationalFILoans");
			this.Property(t => t.ExportCredit).HasColumnName("ExportCredit");
			this.Property(t => t.FBCommercialLoans).HasColumnName("FBCommercialLoans");
			this.Property(t => t.AbroadBondIssuance).HasColumnName("AbroadBondIssuance");
			this.Property(t => t.GYoYofTotalFI).HasColumnName("GYoYofTotalFI");
			this.Property(t => t.GYoYofFDI).HasColumnName("GYoYofFDI");
			this.Property(t => t.GYoYofJV).HasColumnName("GYoYofJV");
			this.Property(t => t.GYoYofSFCooperative).HasColumnName("GYoYofSFCooperative");
			this.Property(t => t.GYoYofWFOE).HasColumnName("GYoYofWFOE");
			this.Property(t => t.GYoYofFIStockCompany).HasColumnName("GYoYofFIStockCompany");
			this.Property(t => t.GYoYofJointDevelopment).HasColumnName("GYoYofJointDevelopment");
			this.Property(t => t.GYoYofOthers).HasColumnName("GYoYofOthers");
			this.Property(t => t.GYoYofOtherFI).HasColumnName("GYoYofOtherFI");
			this.Property(t => t.GYoYofAbroadStockIssuance).HasColumnName("GYoYofAbroadStockIssuance");
			this.Property(t => t.GYoYofInternationalLease).HasColumnName("GYoYofInternationalLease");
			this.Property(t => t.GYoYofCompensatedTrade).HasColumnName("GYoYofCompensatedTrade");
			this.Property(t => t.GYoYofAssemblyProcessing).HasColumnName("GYoYofAssemblyProcessing");
			this.Property(t => t.GYoYofForeignLoans).HasColumnName("GYoYofForeignLoans");
			this.Property(t => t.GYoYofFGovLoans).HasColumnName("GYoYofFGovLoans");
			this.Property(t => t.GYoYofInternationalFILoans).HasColumnName("GYoYofInternationalFILoans");
			this.Property(t => t.GYoYofExportCredit).HasColumnName("GYoYofExportCredit");
			this.Property(t => t.GYoYofFBCommercialLoans).HasColumnName("GYoYofFBCommercialLoans");
			this.Property(t => t.GYoYofAbroadBondIssuance).HasColumnName("GYoYofAbroadBondIssuance");
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
		}
	}
}

