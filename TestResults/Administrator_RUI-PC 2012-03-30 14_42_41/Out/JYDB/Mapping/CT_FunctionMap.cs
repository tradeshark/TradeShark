using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_FunctionMap : EntityTypeConfiguration<CT_Function>
	{
		public CT_FunctionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.FuncCode, t.ParaCode, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.FuncCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FuncName)
				.HasMaxLength(50);
				
			this.Property(t => t.ParaCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("CT_Function");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.FuncCode).HasColumnName("FuncCode");
			this.Property(t => t.FuncName).HasColumnName("FuncName");
			this.Property(t => t.ParaCode).HasColumnName("ParaCode");
			this.Property(t => t.XPara).HasColumnName("XPara");
			this.Property(t => t.YPara).HasColumnName("YPara");
			this.Property(t => t.FuncResult).HasColumnName("FuncResult");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

