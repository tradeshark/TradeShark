using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AuditOpinionMap : EntityTypeConfiguration<LC_AuditOpinion>
	{
		public LC_AuditOpinionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.AccountingFirms)
				.HasMaxLength(100);
				
			this.Property(t => t.CPA)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_AuditOpinion");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AccountingFirms).HasColumnName("AccountingFirms");
			this.Property(t => t.InstiBelongedCode).HasColumnName("InstiBelongedCode");
			this.Property(t => t.CPA).HasColumnName("CPA");
			this.Property(t => t.OpinionType).HasColumnName("OpinionType");
			this.Property(t => t.OpinionFullText).HasColumnName("OpinionFullText");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

