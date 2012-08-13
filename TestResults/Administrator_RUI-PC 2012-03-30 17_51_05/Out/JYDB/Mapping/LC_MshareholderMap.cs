using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MshareholderMap : EntityTypeConfiguration<LC_Mshareholder>
	{
		public LC_MshareholderMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.MSHName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.MSHName)
				.IsRequired()
				.HasMaxLength(120);
				
			this.Property(t => t.LegalRepr)
				.HasMaxLength(50);
				
			this.Property(t => t.MainBusiness)
				.HasMaxLength(255);
				
			this.Property(t => t.NationalityDesc)
				.HasMaxLength(256);
				
			this.Property(t => t.PermanentResidency)
				.HasMaxLength(256);
				
			// Table & Column Mappings
			this.ToTable("LC_Mshareholder");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.MSHName).HasColumnName("MSHName");
			this.Property(t => t.MSHPercentage).HasColumnName("MSHPercentage");
			this.Property(t => t.MSHNumber).HasColumnName("MSHNumber");
			this.Property(t => t.GetMethod).HasColumnName("GetMethod");
			this.Property(t => t.LegalRepr).HasColumnName("LegalRepr");
			this.Property(t => t.RegCapital).HasColumnName("RegCapital");
			this.Property(t => t.MainBusiness).HasColumnName("MainBusiness");
			this.Property(t => t.EconomicNature).HasColumnName("EconomicNature");
			this.Property(t => t.BackgroundIntr).HasColumnName("BackgroundIntr");
			this.Property(t => t.IfExisted).HasColumnName("IfExisted");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.NationalityDesc).HasColumnName("NationalityDesc");
			this.Property(t => t.PermanentResidency).HasColumnName("PermanentResidency");
			this.Property(t => t.StructureChart).HasColumnName("StructureChart");
			this.Property(t => t.FileType).HasColumnName("FileType");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
		}
	}
}

