using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_InvestAdvisorOutlineMap : EntityTypeConfiguration<MF_InvestAdvisorOutline>
	{
		public MF_InvestAdvisorOutlineMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InvestAdvisorCode, t.InvestAdvisorName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InvestAdvisorCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InvestAdvisorName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.InvestAdvisorAbbrName)
				.HasMaxLength(50);
				
			this.Property(t => t.LegalRepr)
				.HasMaxLength(50);
				
			this.Property(t => t.GeneralManager)
				.HasMaxLength(50);
				
			this.Property(t => t.OrganizationForm)
				.HasMaxLength(50);
				
			this.Property(t => t.RegAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.OfficeAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.ZipCode)
				.HasMaxLength(6);
				
			this.Property(t => t.Email)
				.HasMaxLength(50);
				
			this.Property(t => t.ContactAddr)
				.HasMaxLength(100);
				
			this.Property(t => t.Tel)
				.HasMaxLength(50);
				
			this.Property(t => t.Fax)
				.HasMaxLength(50);
				
			this.Property(t => t.WebSite)
				.HasMaxLength(50);
				
			this.Property(t => t.LinkMan)
				.HasMaxLength(50);
				
			this.Property(t => t.ServiceLine)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MF_InvestAdvisorOutline");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InvestAdvisorCode).HasColumnName("InvestAdvisorCode");
			this.Property(t => t.InvestAdvisorName).HasColumnName("InvestAdvisorName");
			this.Property(t => t.InvestAdvisorAbbrName).HasColumnName("InvestAdvisorAbbrName");
			this.Property(t => t.LegalRepr).HasColumnName("LegalRepr");
			this.Property(t => t.GeneralManager).HasColumnName("GeneralManager");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.OrganizationForm).HasColumnName("OrganizationForm");
			this.Property(t => t.RegCapital).HasColumnName("RegCapital");
			this.Property(t => t.RegAddr).HasColumnName("RegAddr");
			this.Property(t => t.OfficeAddr).HasColumnName("OfficeAddr");
			this.Property(t => t.ZipCode).HasColumnName("ZipCode");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.ContactAddr).HasColumnName("ContactAddr");
			this.Property(t => t.Tel).HasColumnName("Tel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.WebSite).HasColumnName("WebSite");
			this.Property(t => t.LinkMan).HasColumnName("LinkMan");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.Region).HasColumnName("Region");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ServiceLine).HasColumnName("ServiceLine");
		}
	}
}

