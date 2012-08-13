using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_FundArchivesMap : EntityTypeConfiguration<View_JJ_FundArchives>
	{
		public View_JJ_FundArchivesMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_InvestAdvisorCode)
				.HasMaxLength(100);
				
			this.Property(t => t.N_TrusteeCode)
				.HasMaxLength(100);
				
			this.Property(t => t.N_Type)
				.HasMaxLength(300);
				
			this.Property(t => t.N_InvestmentType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_InvestStyle)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Manager)
				.HasMaxLength(50);
				
			this.Property(t => t.Warrantor)
				.HasMaxLength(250);
				
			this.Property(t => t.InvestOrientation)
				.HasMaxLength(250);
				
			this.Property(t => t.InvestTarget)
				.HasMaxLength(1000);
				
			this.Property(t => t.PerformanceBenchMark)
				.HasMaxLength(1000);
				
			this.Property(t => t.ProfitDistributionRule)
				.HasMaxLength(2000);
				
			this.Property(t => t.InvestField)
				.HasMaxLength(2000);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_FundArchives");
			this.Property(t => t.N_InvestAdvisorCode).HasColumnName("N_InvestAdvisorCode");
			this.Property(t => t.N_TrusteeCode).HasColumnName("N_TrusteeCode");
			this.Property(t => t.N_Type).HasColumnName("N_Type");
			this.Property(t => t.N_InvestmentType).HasColumnName("N_InvestmentType");
			this.Property(t => t.N_InvestStyle).HasColumnName("N_InvestStyle");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.Duration).HasColumnName("Duration");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.ExpireDate).HasColumnName("ExpireDate");
			this.Property(t => t.Manager).HasColumnName("Manager");
			this.Property(t => t.InvestAdvisorCode).HasColumnName("InvestAdvisorCode");
			this.Property(t => t.TrusteeCode).HasColumnName("TrusteeCode");
			this.Property(t => t.Warrantor).HasColumnName("Warrantor");
			this.Property(t => t.Type).HasColumnName("Type");
			this.Property(t => t.InvestmentType).HasColumnName("InvestmentType");
			this.Property(t => t.InvestStyle).HasColumnName("InvestStyle");
			this.Property(t => t.FoundedSize).HasColumnName("FoundedSize");
			this.Property(t => t.InvestOrientation).HasColumnName("InvestOrientation");
			this.Property(t => t.InvestTarget).HasColumnName("InvestTarget");
			this.Property(t => t.PerformanceBenchMark).HasColumnName("PerformanceBenchMark");
			this.Property(t => t.ProfitDistributionRule).HasColumnName("ProfitDistributionRule");
			this.Property(t => t.InvestField).HasColumnName("InvestField");
			this.Property(t => t.BriefIntro).HasColumnName("BriefIntro");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

