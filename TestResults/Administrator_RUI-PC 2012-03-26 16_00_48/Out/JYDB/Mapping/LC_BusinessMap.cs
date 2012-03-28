using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_BusinessMap : EntityTypeConfiguration<LC_Business>
	{
		public LC_BusinessMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfPassed)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.MainBusiness)
				.HasMaxLength(255);
				
			this.Property(t => t.MainName)
				.HasMaxLength(255);
				
			this.Property(t => t.CSRCInduCategory)
				.HasMaxLength(10);
				
			this.Property(t => t.InduEngaged)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_Business");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.IfPassed).HasColumnName("IfPassed");
			this.Property(t => t.BusinessMajor).HasColumnName("BusinessMajor");
			this.Property(t => t.BusinessMinor).HasColumnName("BusinessMinor");
			this.Property(t => t.MainBusiness).HasColumnName("MainBusiness");
			this.Property(t => t.MainName).HasColumnName("MainName");
			this.Property(t => t.CSRCInduCategory).HasColumnName("CSRCInduCategory");
			this.Property(t => t.InduEngaged).HasColumnName("InduEngaged");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

