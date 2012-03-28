using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_CodeChangeMap : EntityTypeConfiguration<View_GP_CodeChange>
	{
		public View_GP_CodeChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.OldCode, t.ID, t.SecuCode, t.InnerCode, t.CompanyCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.NewCode)
				.HasMaxLength(10);
				
			this.Property(t => t.OldCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.SecuCode)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_CodeChange");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.NewCode).HasColumnName("NewCode");
			this.Property(t => t.OldCode).HasColumnName("OldCode");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.CodeDefine).HasColumnName("CodeDefine");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.BeginDate).HasColumnName("BeginDate");
			this.Property(t => t.StopDate).HasColumnName("StopDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

