using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_SystemMap : EntityTypeConfiguration<JYDB_System>
	{
		public JYDB_SystemMap()
		{
			// Primary Key
			this.HasKey(t => new { t.TableName, t.XGRQ });

			// Properties
			this.Property(t => t.TableName)
				.IsRequired()
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("JYDB_System");
			this.Property(t => t.TableName).HasColumnName("TableName");
			this.Property(t => t.LastJSID).HasColumnName("LastJSID");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

