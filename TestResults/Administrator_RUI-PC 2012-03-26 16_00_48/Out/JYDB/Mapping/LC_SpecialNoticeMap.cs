using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SpecialNoticeMap : EntityTypeConfiguration<LC_SpecialNotice>
	{
		public LC_SpecialNoticeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.NoticeType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.NoticeType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.BulletinTypeName)
				.HasMaxLength(200);
				
			this.Property(t => t.EventTypeName)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_SpecialNotice");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.NoticeStartDate).HasColumnName("NoticeStartDate");
			this.Property(t => t.NoticeEndDate).HasColumnName("NoticeEndDate");
			this.Property(t => t.NoticeType).HasColumnName("NoticeType");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.SuspendTime).HasColumnName("SuspendTime");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.BulletinTypeName).HasColumnName("BulletinTypeName");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.EventTypeName).HasColumnName("EventTypeName");
		}
	}
}

