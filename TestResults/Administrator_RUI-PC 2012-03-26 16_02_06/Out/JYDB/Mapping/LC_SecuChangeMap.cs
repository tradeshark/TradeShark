using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SecuChangeMap : EntityTypeConfiguration<LC_SecuChange>
	{
		public LC_SecuChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.SecurityAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.ChiSpelling)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_SecuChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.IfPassed).HasColumnName("IfPassed");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.SecurityAbbr).HasColumnName("SecurityAbbr");
			this.Property(t => t.ChiSpelling).HasColumnName("ChiSpelling");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

