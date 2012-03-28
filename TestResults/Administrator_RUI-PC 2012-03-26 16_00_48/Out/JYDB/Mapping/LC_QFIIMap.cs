using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_QFIIMap : EntityTypeConfiguration<LC_QFII>
	{
		public LC_QFIIMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.ChiName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChiName)
				.IsRequired()
				.HasMaxLength(80);
				
			this.Property(t => t.EngName)
				.HasMaxLength(40);
				
			this.Property(t => t.TrusteeBank)
				.HasMaxLength(80);
				
			this.Property(t => t.TrusteeSecuCo)
				.HasMaxLength(80);
				
			// Table & Column Mappings
			this.ToTable("LC_QFII");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.EngName).HasColumnName("EngName");
			this.Property(t => t.TrusteeBank).HasColumnName("TrusteeBank");
			this.Property(t => t.TrusteeSecuCo).HasColumnName("TrusteeSecuCo");
			this.Property(t => t.AuthorizedDate).HasColumnName("AuthorizedDate");
			this.Property(t => t.FirstQuotaAuthorizedDate).HasColumnName("FirstQuotaAuthorizedDate");
			this.Property(t => t.AccountAuthorizedDate).HasColumnName("AccountAuthorizedDate");
			this.Property(t => t.LatestQuota).HasColumnName("LatestQuota");
			this.Property(t => t.QuotaChangeRecord).HasColumnName("QuotaChangeRecord");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

