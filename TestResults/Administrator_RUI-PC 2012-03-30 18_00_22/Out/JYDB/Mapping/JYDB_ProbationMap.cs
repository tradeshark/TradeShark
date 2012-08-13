using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_ProbationMap : EntityTypeConfiguration<JYDB_Probation>
	{
		public JYDB_ProbationMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TableName, t.ColumnName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.TableName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.ColumnName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("JYDB_Probation");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TableName).HasColumnName("TableName");
			this.Property(t => t.ColumnName).HasColumnName("ColumnName");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

