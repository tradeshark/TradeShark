using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NameChangeMap : EntityTypeConfiguration<LC_NameChange>
	{
		public LC_NameChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.ChiName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ChiName)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.ChiNameAbbr)
				.HasMaxLength(100);
				
			this.Property(t => t.EngName)
				.HasMaxLength(200);
				
			this.Property(t => t.EngNameAbbr)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_NameChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.IfPassed).HasColumnName("IfPassed");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.ChiNameAbbr).HasColumnName("ChiNameAbbr");
			this.Property(t => t.EngName).HasColumnName("EngName");
			this.Property(t => t.EngNameAbbr).HasColumnName("EngNameAbbr");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

