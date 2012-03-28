using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_UserDataDefMap : EntityTypeConfiguration<JYDB_UserDataDef>
	{
		public JYDB_UserDataDefMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.USERID, t.TYPE, t.XGSJ, t.FBSJ, t.JSID });

			// Properties
			this.Property(t => t.USERID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.TYPE)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.SUBTYPE)
				.HasMaxLength(100);
				
			this.Property(t => t.DESCRIPT)
				.HasMaxLength(2000);
				
			// Table & Column Mappings
			this.ToTable("JYDB_UserDataDef");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.USERID).HasColumnName("USERID");
			this.Property(t => t.TYPE).HasColumnName("TYPE");
			this.Property(t => t.SUBTYPE).HasColumnName("SUBTYPE");
			this.Property(t => t.DESCRIPT).HasColumnName("DESCRIPT");
			this.Property(t => t.CONTENT).HasColumnName("CONTENT");
			this.Property(t => t.XGSJ).HasColumnName("XGSJ");
			this.Property(t => t.FBSJ).HasColumnName("FBSJ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

