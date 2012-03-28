using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_StaffMap : EntityTypeConfiguration<LC_Staff>
	{
		public LC_StaffMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.MergeMark, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.MergeMark)
				.IsRequired()
				.HasMaxLength(8);
				
			this.Property(t => t.TypeName)
				.HasMaxLength(50);
				
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_Staff");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.MergeMark).HasColumnName("MergeMark");
			this.Property(t => t.ClassfiedMethod).HasColumnName("ClassfiedMethod");
			this.Property(t => t.TypeName).HasColumnName("TypeName");
			this.Property(t => t.YoungestAge).HasColumnName("YoungestAge");
			this.Property(t => t.OldestAge).HasColumnName("OldestAge");
			this.Property(t => t.EmployeeSum).HasColumnName("EmployeeSum");
			this.Property(t => t.RatioInSum).HasColumnName("RatioInSum");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.TypeCode).HasColumnName("TypeCode");
		}
	}
}

