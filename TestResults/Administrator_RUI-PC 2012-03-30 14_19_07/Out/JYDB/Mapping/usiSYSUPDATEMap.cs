using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class usiSYSUPDATEMap : EntityTypeConfiguration<usiSYSUPDATE>
	{
		public usiSYSUPDATEMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.UPDTYPE, t.FILENAME, t.FILETIME, t.FILEVER, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.UPDTYPE)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.FILEPATH)
				.HasMaxLength(200);
				
			this.Property(t => t.FILENAME)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.FILEVER)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.USERIDLIST)
				.HasMaxLength(8000);
				
			this.Property(t => t.REVC)
				.HasMaxLength(8000);
				
			this.Property(t => t.REVB)
				.HasMaxLength(8000);
				
			// Table & Column Mappings
			this.ToTable("usiSYSUPDATE");
			this.Property(t => t.ID).HasColumnName("ID");
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
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

