using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_NotTextAnnouncementMap : EntityTypeConfiguration<LC_NotTextAnnouncement>
	{
		public LC_NotTextAnnouncementMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Media)
				.HasMaxLength(100);
				
			this.Property(t => t.InfoTitle)
				.HasMaxLength(200);
				
			this.Property(t => t.FileName)
				.HasMaxLength(100);
				
			this.Property(t => t.SubTitle)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_NotTextAnnouncement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Category).HasColumnName("Category");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.LanguageType).HasColumnName("LanguageType");
			this.Property(t => t.FileType).HasColumnName("FileType");
			this.Property(t => t.FileName).HasColumnName("FileName");
			this.Property(t => t.InfoType).HasColumnName("InfoType");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.SubTitle).HasColumnName("SubTitle");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

