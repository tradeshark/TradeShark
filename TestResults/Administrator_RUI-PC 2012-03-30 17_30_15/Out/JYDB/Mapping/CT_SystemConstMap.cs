using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_SystemConstMap : EntityTypeConfiguration<CT_SystemConst>
	{
		public CT_SystemConstMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.LB, t.LBMC, t.DM, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.LB)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.LBMC)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.MS)
				.HasMaxLength(300);
				
			this.Property(t => t.DM)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.CVALUE)
				.HasMaxLength(2000);
				
			// Table & Column Mappings
			this.ToTable("CT_SystemConst");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.LB).HasColumnName("LB");
			this.Property(t => t.LBMC).HasColumnName("LBMC");
			this.Property(t => t.MS).HasColumnName("MS");
			this.Property(t => t.DM).HasColumnName("DM");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.FVALUE).HasColumnName("FVALUE");
			this.Property(t => t.IVALUE).HasColumnName("IVALUE");
			this.Property(t => t.DVALUE).HasColumnName("DVALUE");
			this.Property(t => t.CVALUE).HasColumnName("CVALUE");
		}
	}
}

