using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_AnnouncementMap : EntityTypeConfiguration<MF_Announcement>
	{
		public MF_AnnouncementMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InfoPublDate, t.Category, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Media)
				.HasMaxLength(80);
				
			this.Property(t => t.Category)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoTitle)
				.HasMaxLength(100);
				
			this.Property(t => t.SubTitle)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_Announcement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.Category).HasColumnName("Category");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.SubTitle).HasColumnName("SubTitle");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
		}
	}
}

