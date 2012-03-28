using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_TrusteePersonnelMap : EntityTypeConfiguration<MF_TrusteePersonnel>
	{
		public MF_TrusteePersonnelMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TrusteeCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.TrusteeCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Media)
				.HasMaxLength(100);
				
			this.Property(t => t.PostName)
				.HasMaxLength(50);
				
			this.Property(t => t.Name)
				.HasMaxLength(20);
				
			this.Property(t => t.Gender)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.EducationLevel)
				.HasMaxLength(20);
				
			this.Property(t => t.ConcurrentPost)
				.HasMaxLength(255);
				
			this.Property(t => t.Incumbent)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.Notes)
				.HasMaxLength(250);
				
			// Table & Column Mappings
			this.ToTable("MF_TrusteePersonnel");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TrusteeCode).HasColumnName("TrusteeCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.PostName).HasColumnName("PostName");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.Gender).HasColumnName("Gender");
			this.Property(t => t.BirthDate).HasColumnName("BirthDate");
			this.Property(t => t.EducationLevel).HasColumnName("EducationLevel");
			this.Property(t => t.AccessionDate).HasColumnName("AccessionDate");
			this.Property(t => t.DimissionDate).HasColumnName("DimissionDate");
			this.Property(t => t.ConcurrentPost).HasColumnName("ConcurrentPost");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.Incumbent).HasColumnName("Incumbent");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

