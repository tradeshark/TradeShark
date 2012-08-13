using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ExgIndustryMap : EntityTypeConfiguration<LC_ExgIndustry>
	{
		public LC_ExgIndustryMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.FirstIndustryCode)
				.HasMaxLength(20);
				
			this.Property(t => t.FirstIndustryName)
				.HasMaxLength(100);
				
			this.Property(t => t.SecondIndustryCode)
				.HasMaxLength(20);
				
			this.Property(t => t.SecondIndustryName)
				.HasMaxLength(100);
				
			this.Property(t => t.ThirdIndustryCode)
				.HasMaxLength(20);
				
			this.Property(t => t.ThirdIndustryName)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_ExgIndustry");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Standard).HasColumnName("Standard");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.IfPerformed).HasColumnName("IfPerformed");
			this.Property(t => t.CancelDate).HasColumnName("CancelDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.FirstIndustryCode).HasColumnName("FirstIndustryCode");
			this.Property(t => t.FirstIndustryName).HasColumnName("FirstIndustryName");
			this.Property(t => t.SecondIndustryCode).HasColumnName("SecondIndustryCode");
			this.Property(t => t.SecondIndustryName).HasColumnName("SecondIndustryName");
			this.Property(t => t.ThirdIndustryCode).HasColumnName("ThirdIndustryCode");
			this.Property(t => t.ThirdIndustryName).HasColumnName("ThirdIndustryName");
		}
	}
}

