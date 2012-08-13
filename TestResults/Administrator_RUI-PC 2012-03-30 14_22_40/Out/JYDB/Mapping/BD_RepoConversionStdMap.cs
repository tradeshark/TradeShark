using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_RepoConversionStdMap : EntityTypeConfiguration<BD_RepoConversionStd>
	{
		public BD_RepoConversionStdMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ExecuteDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_RepoConversionStd");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ExecuteDate).HasColumnName("ExecuteDate");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.Coefficient).HasColumnName("Coefficient");
			this.Property(t => t.StdBond).HasColumnName("StdBond");
			this.Property(t => t.Exchange).HasColumnName("Exchange");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

