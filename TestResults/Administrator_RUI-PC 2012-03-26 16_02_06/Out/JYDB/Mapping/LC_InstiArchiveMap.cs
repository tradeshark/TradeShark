using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_InstiArchiveMap : EntityTypeConfiguration<LC_InstiArchive>
	{
		public LC_InstiArchiveMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.ChiName)
				.HasMaxLength(100);
				
			this.Property(t => t.AbbrChiName)
				.HasMaxLength(100);
				
			this.Property(t => t.NameChiSpelling)
				.HasMaxLength(100);
				
			this.Property(t => t.EngName)
				.HasMaxLength(100);
				
			this.Property(t => t.AbbrEngName)
				.HasMaxLength(100);
				
			this.Property(t => t.RegAddr)
				.HasMaxLength(200);
				
			this.Property(t => t.RegZip)
				.IsFixedLength()
				.HasMaxLength(6);
				
			this.Property(t => t.OfficeAddr)
				.HasMaxLength(200);
				
			this.Property(t => t.ContactAddr)
				.HasMaxLength(200);
				
			this.Property(t => t.ContactZip)
				.IsFixedLength()
				.HasMaxLength(6);
				
			this.Property(t => t.Email)
				.HasMaxLength(50);
				
			this.Property(t => t.Website)
				.HasMaxLength(50);
				
			this.Property(t => t.LegalPersonRepr)
				.HasMaxLength(50);
				
			this.Property(t => t.GeneralManager)
				.HasMaxLength(50);
				
			this.Property(t => t.OtherManager)
				.HasMaxLength(50);
				
			this.Property(t => t.Contactman)
				.HasMaxLength(50);
				
			this.Property(t => t.Tel)
				.HasMaxLength(50);
				
			this.Property(t => t.Fax)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_InstiArchive");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.ParentCompany).HasColumnName("ParentCompany");
			this.Property(t => t.ListedCode).HasColumnName("ListedCode");
			this.Property(t => t.InvestAdvisorName).HasColumnName("InvestAdvisorName");
			this.Property(t => t.TrusteeName).HasColumnName("TrusteeName");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.AbbrChiName).HasColumnName("AbbrChiName");
			this.Property(t => t.NameChiSpelling).HasColumnName("NameChiSpelling");
			this.Property(t => t.EngName).HasColumnName("EngName");
			this.Property(t => t.AbbrEngName).HasColumnName("AbbrEngName");
			this.Property(t => t.RegCapital).HasColumnName("RegCapital");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.EconomicNature).HasColumnName("EconomicNature");
			this.Property(t => t.CompanyNature).HasColumnName("CompanyNature");
			this.Property(t => t.CompanyType).HasColumnName("CompanyType");
			this.Property(t => t.RegAddr).HasColumnName("RegAddr");
			this.Property(t => t.RegZip).HasColumnName("RegZip");
			this.Property(t => t.RegCity).HasColumnName("RegCity");
			this.Property(t => t.OfficeAddr).HasColumnName("OfficeAddr");
			this.Property(t => t.ContactAddr).HasColumnName("ContactAddr");
			this.Property(t => t.ContactZip).HasColumnName("ContactZip");
			this.Property(t => t.ContactCity).HasColumnName("ContactCity");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.Website).HasColumnName("Website");
			this.Property(t => t.LegalPersonRepr).HasColumnName("LegalPersonRepr");
			this.Property(t => t.GeneralManager).HasColumnName("GeneralManager");
			this.Property(t => t.OtherManager).HasColumnName("OtherManager");
			this.Property(t => t.Contactman).HasColumnName("Contactman");
			this.Property(t => t.Tel).HasColumnName("Tel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.BriefIntroText).HasColumnName("BriefIntroText");
			this.Property(t => t.BusinessMajor).HasColumnName("BusinessMajor");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.CloseDate).HasColumnName("CloseDate");
			this.Property(t => t.CloseReason).HasColumnName("CloseReason");
			this.Property(t => t.IfExisted).HasColumnName("IfExisted");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

