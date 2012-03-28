using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ForeignInvestmentMap : EntityTypeConfiguration<ED_ForeignInvestment>
	{
		public ED_ForeignInvestmentMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_ForeignInvestment");
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
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

