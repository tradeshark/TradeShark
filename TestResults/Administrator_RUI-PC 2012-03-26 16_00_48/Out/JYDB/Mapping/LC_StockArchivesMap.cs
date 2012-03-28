using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_StockArchivesMap : EntityTypeConfiguration<LC_StockArchives>
	{
		public LC_StockArchivesMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.State, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.State)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SecretaryBD)
				.HasMaxLength(20);
				
			this.Property(t => t.SecuAffairsRepr)
				.HasMaxLength(20);
				
			this.Property(t => t.AuthReprSBD)
				.HasMaxLength(20);
				
			this.Property(t => t.ContactTel)
				.HasMaxLength(60);
				
			this.Property(t => t.ContactFax)
				.HasMaxLength(60);
				
			this.Property(t => t.ContactEmail)
				.HasMaxLength(50);
				
			this.Property(t => t.RegAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.RegZipCode)
				.HasMaxLength(6);
				
			this.Property(t => t.OfficeAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.OfficeZipCode)
				.HasMaxLength(6);
				
			this.Property(t => t.ContactAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.ConatactZipCode)
				.HasMaxLength(6);
				
			this.Property(t => t.Email)
				.HasMaxLength(50);
				
			this.Property(t => t.Website)
				.HasMaxLength(100);
				
			this.Property(t => t.DisclosureWebsites)
				.HasMaxLength(100);
				
			this.Property(t => t.DisclosurePapers)
				.HasMaxLength(160);
				
			this.Property(t => t.IRegPlace)
				.HasMaxLength(100);
				
			this.Property(t => t.LegalRepr)
				.HasMaxLength(20);
				
			this.Property(t => t.GeneralManager)
				.HasMaxLength(100);
				
			this.Property(t => t.LegalConsultant)
				.HasMaxLength(200);
				
			this.Property(t => t.AccountingFirm)
				.HasMaxLength(200);
				
			this.Property(t => t.InduCSRC)
				.HasMaxLength(10);
				
			this.Property(t => t.AShareAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.AStockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.BShareAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.BStockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.HShareAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.HStockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.ChiName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_StockArchives");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.State).HasColumnName("State");
			this.Property(t => t.SecretaryBD).HasColumnName("SecretaryBD");
			this.Property(t => t.SecuAffairsRepr).HasColumnName("SecuAffairsRepr");
			this.Property(t => t.AuthReprSBD).HasColumnName("AuthReprSBD");
			this.Property(t => t.ContactTel).HasColumnName("ContactTel");
			this.Property(t => t.ContactFax).HasColumnName("ContactFax");
			this.Property(t => t.ContactEmail).HasColumnName("ContactEmail");
			this.Property(t => t.RegAddr).HasColumnName("RegAddr");
			this.Property(t => t.RegZipCode).HasColumnName("RegZipCode");
			this.Property(t => t.OfficeAddr).HasColumnName("OfficeAddr");
			this.Property(t => t.OfficeZipCode).HasColumnName("OfficeZipCode");
			this.Property(t => t.ContactAddr).HasColumnName("ContactAddr");
			this.Property(t => t.ConatactZipCode).HasColumnName("ConatactZipCode");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.Website).HasColumnName("Website");
			this.Property(t => t.DisclosureWebsites).HasColumnName("DisclosureWebsites");
			this.Property(t => t.DisclosurePapers).HasColumnName("DisclosurePapers");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.IRegPlace).HasColumnName("IRegPlace");
			this.Property(t => t.LegalRepr).HasColumnName("LegalRepr");
			this.Property(t => t.GeneralManager).HasColumnName("GeneralManager");
			this.Property(t => t.LegalConsultant).HasColumnName("LegalConsultant");
			this.Property(t => t.AccountingFirm).HasColumnName("AccountingFirm");
			this.Property(t => t.InduCSRC).HasColumnName("InduCSRC");
			this.Property(t => t.BusinessMajor).HasColumnName("BusinessMajor");
			this.Property(t => t.BusinessMinor).HasColumnName("BusinessMinor");
			this.Property(t => t.AShareAbbr).HasColumnName("AShareAbbr");
			this.Property(t => t.AStockCode).HasColumnName("AStockCode");
			this.Property(t => t.BShareAbbr).HasColumnName("BShareAbbr");
			this.Property(t => t.BStockCode).HasColumnName("BStockCode");
			this.Property(t => t.HShareAbbr).HasColumnName("HShareAbbr");
			this.Property(t => t.HStockCode).HasColumnName("HStockCode");
			this.Property(t => t.BriefIntroText).HasColumnName("BriefIntroText");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
		}
	}
}

