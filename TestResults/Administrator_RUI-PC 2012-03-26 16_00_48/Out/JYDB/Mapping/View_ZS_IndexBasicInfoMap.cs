using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_ZS_IndexBasicInfoMap : EntityTypeConfiguration<View_ZS_IndexBasicInfo>
	{
		public View_ZS_IndexBasicInfoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.IndexCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.SecuCode)
				.HasMaxLength(10);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.N_IndexType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ComponentType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndustryStandard)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndustryType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_PubOrgCode)
				.HasMaxLength(100);
				
			this.Property(t => t.N_CreatIndexOrgCode)
				.HasMaxLength(100);
				
			this.Property(t => t.N_WAMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ComponentAdPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.IndexCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.PubOrgName)
				.HasMaxLength(200);
				
			this.Property(t => t.CreatIndexOrgName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("View_ZS_IndexBasicInfo");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.N_IndexType).HasColumnName("N_IndexType");
			this.Property(t => t.N_ComponentType).HasColumnName("N_ComponentType");
			this.Property(t => t.N_IndustryStandard).HasColumnName("N_IndustryStandard");
			this.Property(t => t.N_IndustryType).HasColumnName("N_IndustryType");
			this.Property(t => t.N_PubOrgCode).HasColumnName("N_PubOrgCode");
			this.Property(t => t.N_CreatIndexOrgCode).HasColumnName("N_CreatIndexOrgCode");
			this.Property(t => t.N_WAMethod).HasColumnName("N_WAMethod");
			this.Property(t => t.N_ComponentAdPeriod).HasColumnName("N_ComponentAdPeriod");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.IndexCode).HasColumnName("IndexCode");
			this.Property(t => t.IndexType).HasColumnName("IndexType");
			this.Property(t => t.ComponentType).HasColumnName("ComponentType");
			this.Property(t => t.IndustryStandard).HasColumnName("IndustryStandard");
			this.Property(t => t.IndustryType).HasColumnName("IndustryType");
			this.Property(t => t.PubOrgCode).HasColumnName("PubOrgCode");
			this.Property(t => t.PubOrgName).HasColumnName("PubOrgName");
			this.Property(t => t.CreatIndexOrgCode).HasColumnName("CreatIndexOrgCode");
			this.Property(t => t.CreatIndexOrgName).HasColumnName("CreatIndexOrgName");
			this.Property(t => t.PubDate).HasColumnName("PubDate");
			this.Property(t => t.BaseDate).HasColumnName("BaseDate");
			this.Property(t => t.BasePoint).HasColumnName("BasePoint");
			this.Property(t => t.WAMethod).HasColumnName("WAMethod");
			this.Property(t => t.ComponentSum).HasColumnName("ComponentSum");
			this.Property(t => t.ComponentAdPeriod).HasColumnName("ComponentAdPeriod");
			this.Property(t => t.IndexRemark).HasColumnName("IndexRemark");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

