using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CertificationMap : EntityTypeConfiguration<LC_Certification>
	{
		public LC_CertificationMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Organization)
				.HasMaxLength(100);
				
			this.Property(t => t.ValidTerm)
				.HasMaxLength(50);
				
			this.Property(t => t.CetificationProject)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_Certification");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.IfCertified).HasColumnName("IfCertified");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.CetificationTime).HasColumnName("CetificationTime");
			this.Property(t => t.Organization).HasColumnName("Organization");
			this.Property(t => t.CetificationType).HasColumnName("CetificationType");
			this.Property(t => t.ValidTerm).HasColumnName("ValidTerm");
			this.Property(t => t.CetificationGrade).HasColumnName("CetificationGrade");
			this.Property(t => t.CetificationObject).HasColumnName("CetificationObject");
			this.Property(t => t.CetificationProject).HasColumnName("CetificationProject");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

