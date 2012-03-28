using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class JYDB_SysUpdateMap : EntityTypeConfiguration<JYDB_SysUpdate>
	{
		public JYDB_SysUpdateMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.PRDNO, t.UPDTYPE, t.FILETIME, t.FILEVER, t.GKBZ, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.PRDNO)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.UPDTYPE)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FILEPATH)
				.HasMaxLength(200);
				
			this.Property(t => t.FILENAME)
				.HasMaxLength(200);
				
			this.Property(t => t.FILEVER)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.USERIDLIST)
				.HasMaxLength(8000);
				
			this.Property(t => t.REVC)
				.HasMaxLength(8000);
				
			this.Property(t => t.REVB)
				.HasMaxLength(8000);
				
			this.Property(t => t.GKBZ)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("JYDB_SysUpdate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.PRDNO).HasColumnName("PRDNO");
			this.Property(t => t.UPDTYPE).HasColumnName("UPDTYPE");
			this.Property(t => t.FILEPATH).HasColumnName("FILEPATH");
			this.Property(t => t.FILENAME).HasColumnName("FILENAME");
			this.Property(t => t.FILETIME).HasColumnName("FILETIME");
			this.Property(t => t.FILEVER).HasColumnName("FILEVER");
			this.Property(t => t.USERIDLIST).HasColumnName("USERIDLIST");
			this.Property(t => t.REVI).HasColumnName("REVI");
			this.Property(t => t.REVD).HasColumnName("REVD");
			this.Property(t => t.REVC).HasColumnName("REVC");
			this.Property(t => t.REVB).HasColumnName("REVB");
			this.Property(t => t.FILEDATA).HasColumnName("FILEDATA");
			this.Property(t => t.GKBZ).HasColumnName("GKBZ");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

