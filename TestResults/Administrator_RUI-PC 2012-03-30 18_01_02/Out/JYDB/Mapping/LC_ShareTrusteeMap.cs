using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ShareTrusteeMap : EntityTypeConfiguration<LC_ShareTrustee>
	{
		public LC_ShareTrusteeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.Authorizer, t.AuthorizedReceiver, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Authorizer)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.AuthorizedReceiver)
				.IsRequired()
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_ShareTrustee");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Authorizer).HasColumnName("Authorizer");
			this.Property(t => t.AuthorizerHoldSum).HasColumnName("AuthorizerHoldSum");
			this.Property(t => t.AuthorizedReceiver).HasColumnName("AuthorizedReceiver");
			this.Property(t => t.InvolvedTrustSum).HasColumnName("InvolvedTrustSum");
			this.Property(t => t.PCTOfAuthorizer).HasColumnName("PCTOfAuthorizer");
			this.Property(t => t.PCTOfFullShares).HasColumnName("PCTOfFullShares");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.TrustStatement).HasColumnName("TrustStatement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

