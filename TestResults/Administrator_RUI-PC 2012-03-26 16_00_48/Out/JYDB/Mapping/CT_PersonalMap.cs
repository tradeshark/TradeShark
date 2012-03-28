using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class CT_PersonalMap : EntityTypeConfiguration<CT_Personal>
	{
		public CT_PersonalMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.PersonalName)
				.HasMaxLength(100);
				
			this.Property(t => t.WorkPlace)
				.HasMaxLength(200);
				
			this.Property(t => t.Gender)
				.HasMaxLength(2);
				
			this.Property(t => t.BirthY)
				.HasMaxLength(4);
				
			this.Property(t => t.Education)
				.HasMaxLength(50);
				
			this.Property(t => t.ProfessionalTitle)
				.HasMaxLength(200);
				
			this.Property(t => t.Tel)
				.HasMaxLength(100);
				
			this.Property(t => t.Fax)
				.HasMaxLength(100);
				
			this.Property(t => t.Email)
				.HasMaxLength(200);
				
			this.Property(t => t.MajorName)
				.HasMaxLength(100);
				
			this.Property(t => t.PositionName)
				.HasMaxLength(200);
				
			this.Property(t => t.Remark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("CT_Personal");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PersonalType).HasColumnName("PersonalType");
			this.Property(t => t.PersonalNum).HasColumnName("PersonalNum");
			this.Property(t => t.PersonalName).HasColumnName("PersonalName");
			this.Property(t => t.WorkPlace).HasColumnName("WorkPlace");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.Gender).HasColumnName("Gender");
			this.Property(t => t.BirthY).HasColumnName("BirthY");
			this.Property(t => t.Education).HasColumnName("Education");
			this.Property(t => t.ProfessionalTitle).HasColumnName("ProfessionalTitle");
			this.Property(t => t.Tel).HasColumnName("Tel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.MajorName).HasColumnName("MajorName");
			this.Property(t => t.PositionName).HasColumnName("PositionName");
			this.Property(t => t.Remark).HasColumnName("Remark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

