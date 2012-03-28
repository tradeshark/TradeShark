using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CapitalInvestMap : EntityTypeConfiguration<LC_CapitalInvest>
	{
		public LC_CapitalInvestMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.InvestProject)
				.HasMaxLength(255);
				
			this.Property(t => t.ProjectSwitchedTo)
				.HasMaxLength(255);
				
			this.Property(t => t.Transferor)
				.HasMaxLength(255);
				
			this.Property(t => t.TargetName)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_CapitalInvest");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPunlDate).HasColumnName("InitialInfoPunlDate");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.RaisingMethod).HasColumnName("RaisingMethod");
			this.Property(t => t.InvestProject).HasColumnName("InvestProject");
			this.Property(t => t.ProjectStatement).HasColumnName("ProjectStatement");
			this.Property(t => t.PlannedSum).HasColumnName("PlannedSum");
			this.Property(t => t.ActualInvestEndDate).HasColumnName("ActualInvestEndDate");
			this.Property(t => t.ActualSum).HasColumnName("ActualSum");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.InvestField).HasColumnName("InvestField");
			this.Property(t => t.ProceedingStatement).HasColumnName("ProceedingStatement");
			this.Property(t => t.IfSwitched).HasColumnName("IfSwitched");
			this.Property(t => t.ProjectSwitchedTo).HasColumnName("ProjectSwitchedTo");
			this.Property(t => t.SumSwitched).HasColumnName("SumSwitched");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.PurchaseType).HasColumnName("PurchaseType");
			this.Property(t => t.BookValue).HasColumnName("BookValue");
			this.Property(t => t.AppraisalValue).HasColumnName("AppraisalValue");
			this.Property(t => t.PurchasePrice).HasColumnName("PurchasePrice");
			this.Property(t => t.EquityRatio).HasColumnName("EquityRatio");
			this.Property(t => t.Transferor).HasColumnName("Transferor");
			this.Property(t => t.Relationship).HasColumnName("Relationship");
			this.Property(t => t.InvolvedStock).HasColumnName("InvolvedStock");
			this.Property(t => t.TransferorNature).HasColumnName("TransferorNature");
			this.Property(t => t.TargetName).HasColumnName("TargetName");
			this.Property(t => t.TargetNature).HasColumnName("TargetNature");
		}
	}
}

