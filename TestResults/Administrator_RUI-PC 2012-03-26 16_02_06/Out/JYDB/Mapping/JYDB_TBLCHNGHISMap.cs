using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_TBLCHNGHISMap : EntityTypeConfiguration<JYDB_TBLCHNGHIS>
	{
		public JYDB_TBLCHNGHISMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TABLENAME, t.RECCOUNT, t.XGSJ, t.JSID });

			// Properties
			this.Property(t => t.TABLENAME)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.RECCOUNT)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("JYDB_TBLCHNGHIS");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TABLENAME).HasColumnName("TABLENAME");
			this.Property(t => t.RECCOUNT).HasColumnName("RECCOUNT");
			this.Property(t => t.XGSJ).HasColumnName("XGSJ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

