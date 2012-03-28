using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_AdvisorShareholderMap : EntityTypeConfiguration<MF_AdvisorShareholder>
	{
		public MF_AdvisorShareholderMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InvestAdvisorCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InvestAdvisorCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Name)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_AdvisorShareholder");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InvestAdvisorCode).HasColumnName("InvestAdvisorCode");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.InstitutionCode).HasColumnName("InstitutionCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.HoldingShares).HasColumnName("HoldingShares");
			this.Property(t => t.HoldingRatio).HasColumnName("HoldingRatio");
			this.Property(t => t.IfExisted).HasColumnName("IfExisted");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

