using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CodeChangeMap : EntityTypeConfiguration<LC_CodeChange>
	{
		public LC_CodeChangeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.SecuCode)
				.IsRequired()
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("LC_CodeChange");
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

