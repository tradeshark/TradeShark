using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_DeleteRecMap : EntityTypeConfiguration<JYDB_DeleteRec>
	{
		public JYDB_DeleteRecMap()
		{
			// Primary Key
			this.HasKey(t => new { t.TABLENAME, t.RECID, t.XGRQ, t.ID, t.JSID });

			// Properties
			this.Property(t => t.TABLENAME)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.RECID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("JYDB_DeleteRec");
			this.Property(t => t.TABLENAME).HasColumnName("TABLENAME");
			this.Property(t => t.RECID).HasColumnName("RECID");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

