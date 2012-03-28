using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_StockArchivesMap : EntityTypeConfiguration<HK_StockArchives>
	{
		public HK_StockArchivesMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Business)
				.HasMaxLength(1000);
				
			this.Property(t => t.Chairman)
				.HasMaxLength(100);
				
			this.Property(t => t.CompanySecretary)
				.HasMaxLength(100);
				
			this.Property(t => t.CertifiedAccountant)
				.HasMaxLength(100);
				
			this.Property(t => t.RegisteredOffice)
				.HasMaxLength(200);
				
			this.Property(t => t.GeneralOffice)
				.HasMaxLength(200);
				
			this.Property(t => t.Registrars)
				.HasMaxLength(200);
				
			this.Property(t => t.Tel)
				.HasMaxLength(50);
				
			this.Property(t => t.Fax)
				.HasMaxLength(50);
				
			this.Property(t => t.Eail)
				.HasMaxLength(50);
				
			this.Property(t => t.Website)
				.HasMaxLength(200);
				
			this.Property(t => t.CompanyTypeDesc)
				.HasMaxLength(50);
				
			this.Property(t => t.ChiName)
				.HasMaxLength(200);
				
			this.Property(t => t.AuditInstitution)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_StockArchives");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.RegAbbr).HasColumnName("RegAbbr");
			this.Property(t => t.Business).HasColumnName("Business");
			this.Property(t => t.InduCHKE).HasColumnName("InduCHKE");
			this.Property(t => t.InduCHS).HasColumnName("InduCHS");
			this.Property(t => t.Chairman).HasColumnName("Chairman");
			this.Property(t => t.CompanySecretary).HasColumnName("CompanySecretary");
			this.Property(t => t.CertifiedAccountant).HasColumnName("CertifiedAccountant");
			this.Property(t => t.RegisteredOffice).HasColumnName("RegisteredOffice");
			this.Property(t => t.GeneralOffice).HasColumnName("GeneralOffice");
			this.Property(t => t.Registrars).HasColumnName("Registrars");
			this.Property(t => t.Tel).HasColumnName("Tel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.Eail).HasColumnName("Eail");
			this.Property(t => t.Website).HasColumnName("Website");
			this.Property(t => t.BriefIntroduction).HasColumnName("BriefIntroduction");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.CompanyType).HasColumnName("CompanyType");
			this.Property(t => t.CompanyTypeDesc).HasColumnName("CompanyTypeDesc");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.AuditInstitution).HasColumnName("AuditInstitution");
			this.Property(t => t.RegCapital).HasColumnName("RegCapital");
			this.Property(t => t.RegCapitalCurrency).HasColumnName("RegCapitalCurrency");
		}
	}
}

