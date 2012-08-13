using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_IndexBasicInfoMap : EntityTypeConfiguration<LC_IndexBasicInfo>
	{
		public LC_IndexBasicInfoMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.PubOrgName)
				.HasMaxLength(200);
				
			this.Property(t => t.CreatIndexOrgName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_IndexBasicInfo");
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

