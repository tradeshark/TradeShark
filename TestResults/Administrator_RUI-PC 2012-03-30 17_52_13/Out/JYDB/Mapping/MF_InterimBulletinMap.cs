using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_InterimBulletinMap : EntityTypeConfiguration<MF_InterimBulletin>
	{
		public MF_InterimBulletinMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.BulletinDate, t.InfoTitle, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoTitle)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.Media)
				.HasMaxLength(80);
				
			// Table & Column Mappings
			this.ToTable("MF_InterimBulletin");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.BulletinDate).HasColumnName("BulletinDate");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.Detail).HasColumnName("Detail");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.Market).HasColumnName("Market");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
		}
	}
}

