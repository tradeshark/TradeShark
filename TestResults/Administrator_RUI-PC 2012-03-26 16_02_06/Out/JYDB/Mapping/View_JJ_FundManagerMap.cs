using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_FundManagerMap : EntityTypeConfiguration<View_JJ_FundManager>
	{
		public View_JJ_FundManagerMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_Incumbent, t.N_Gender, t.ID, t.InnerCode, t.PostName, t.Name, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_EducationLevel)
				.HasMaxLength(300);
				
			this.Property(t => t.N_PostName)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Incumbent)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.N_Gender)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.PostName)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.Gender)
				.IsFixedLength()
				.HasMaxLength(10);
				
			this.Property(t => t.Notes)
				.HasMaxLength(250);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_FundManager");
			this.Property(t => t.N_EducationLevel).HasColumnName("N_EducationLevel");
			this.Property(t => t.N_PostName).HasColumnName("N_PostName");
			this.Property(t => t.N_Incumbent).HasColumnName("N_Incumbent");
			this.Property(t => t.N_Gender).HasColumnName("N_Gender");
			this.Property(t => t.N_Performance).HasColumnName("N_Performance");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PostName).HasColumnName("PostName");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.Gender).HasColumnName("Gender");
			this.Property(t => t.BirthDate).HasColumnName("BirthDate");
			this.Property(t => t.AccessionDate).HasColumnName("AccessionDate");
			this.Property(t => t.DimissionDate).HasColumnName("DimissionDate");
			this.Property(t => t.Performance).HasColumnName("Performance");
			this.Property(t => t.EducationLevel).HasColumnName("EducationLevel");
			this.Property(t => t.ExperienceTime).HasColumnName("ExperienceTime");
			this.Property(t => t.PracticeDate).HasColumnName("PracticeDate");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.Incumbent).HasColumnName("Incumbent");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

