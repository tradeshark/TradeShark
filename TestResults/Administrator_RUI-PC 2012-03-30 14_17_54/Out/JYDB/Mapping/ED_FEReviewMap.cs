using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_FEReviewMap : EntityTypeConfiguration<ED_FEReview>
	{
		public ED_FEReviewMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Media)
				.HasMaxLength(200);
				
			this.Property(t => t.Writer)
				.HasMaxLength(50);
				
			this.Property(t => t.Author)
				.HasMaxLength(50);
				
			this.Property(t => t.InfoTitle)
				.IsRequired()
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("ED_FEReview");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.Writer).HasColumnName("Writer");
			this.Property(t => t.Author).HasColumnName("Author");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.ObjectCode).HasColumnName("ObjectCode");
			this.Property(t => t.AreaCode).HasColumnName("AreaCode");
			this.Property(t => t.InvolvedInstitution).HasColumnName("InvolvedInstitution");
			this.Property(t => t.InfoLevel).HasColumnName("InfoLevel");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
		}
	}
}

