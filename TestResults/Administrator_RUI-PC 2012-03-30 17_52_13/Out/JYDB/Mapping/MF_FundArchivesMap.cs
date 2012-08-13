using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FundArchivesMap : EntityTypeConfiguration<MF_FundArchives>
	{
		public MF_FundArchivesMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Manager)
				.HasMaxLength(50);
				
			this.Property(t => t.Warrantor)
				.HasMaxLength(250);
				
			this.Property(t => t.InvestOrientation)
				.HasMaxLength(1000);
				
			this.Property(t => t.InvestTarget)
				.HasMaxLength(500);
				
			this.Property(t => t.PerformanceBenchMark)
				.HasMaxLength(500);
				
			this.Property(t => t.ProfitDistributionRule)
				.HasMaxLength(500);
				
			this.Property(t => t.InvestField)
				.HasMaxLength(2000);
				
			this.Property(t => t.ApplyingCodeFront)
				.HasMaxLength(10);
				
			this.Property(t => t.ApplyingCodeBack)
				.HasMaxLength(10);
				
			this.Property(t => t.RiskReturncharacter)
				.HasMaxLength(500);
				
			this.Property(t => t.LowestSumSubscribing)
				.HasMaxLength(500);
				
			this.Property(t => t.LSFRDescription)
				.HasMaxLength(200);
				
			this.Property(t => t.LSFHDescription)
				.HasMaxLength(200);
				
			this.Property(t => t.FundType)
				.HasMaxLength(100);
				
			this.Property(t => t.CarryOverDateRemark)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_FundArchives");
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
			this.Property(t => t.ApplyingCodeFront).HasColumnName("ApplyingCodeFront");
			this.Property(t => t.ApplyingCodeBack).HasColumnName("ApplyingCodeBack");
			this.Property(t => t.GuaranteedPeriod).HasColumnName("GuaranteedPeriod");
			this.Property(t => t.RiskReturncharacter).HasColumnName("RiskReturncharacter");
			this.Property(t => t.LowestSumSubscribing).HasColumnName("LowestSumSubscribing");
			this.Property(t => t.LowestSumRedemption).HasColumnName("LowestSumRedemption");
			this.Property(t => t.LSFRDescription).HasColumnName("LSFRDescription");
			this.Property(t => t.LowestSumForHolding).HasColumnName("LowestSumForHolding");
			this.Property(t => t.LSFHDescription).HasColumnName("LSFHDescription");
			this.Property(t => t.FundNature).HasColumnName("FundNature");
			this.Property(t => t.FundTypeCode).HasColumnName("FundTypeCode");
			this.Property(t => t.FundType).HasColumnName("FundType");
			this.Property(t => t.CarryOverDate).HasColumnName("CarryOverDate");
			this.Property(t => t.CarryOverDateRemark).HasColumnName("CarryOverDateRemark");
			this.Property(t => t.CarryOverType).HasColumnName("CarryOverType");
		}
	}
}

