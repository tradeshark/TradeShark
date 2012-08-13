using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_RelationshipMap : EntityTypeConfiguration<LC_Relationship>
	{
		public LC_RelationshipMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Media)
				.HasMaxLength(80);
				
			this.Property(t => t.RelatedPartyName)
				.IsRequired()
				.HasMaxLength(120);
				
			this.Property(t => t.RelatedShareholderName)
				.HasMaxLength(200);
				
			this.Property(t => t.LegalPersonRepr)
				.HasMaxLength(50);
				
			this.Property(t => t.ShareType)
				.HasMaxLength(50);
				
			this.Property(t => t.MainBusiness)
				.HasMaxLength(255);
				
			this.Property(t => t.Notes)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_Relationship");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.RelatedPartyName).HasColumnName("RelatedPartyName");
			this.Property(t => t.Relationship).HasColumnName("Relationship");
			this.Property(t => t.RelatedShareholderName).HasColumnName("RelatedShareholderName");
			this.Property(t => t.LegalPersonRepr).HasColumnName("LegalPersonRepr");
			this.Property(t => t.RegCapital).HasColumnName("RegCapital");
			this.Property(t => t.EquityRatio).HasColumnName("EquityRatio");
			this.Property(t => t.InvestSum).HasColumnName("InvestSum");
			this.Property(t => t.ShareAmount).HasColumnName("ShareAmount");
			this.Property(t => t.ShareType).HasColumnName("ShareType");
			this.Property(t => t.MainBusiness).HasColumnName("MainBusiness");
			this.Property(t => t.Industry).HasColumnName("Industry");
			this.Property(t => t.InvestTerm).HasColumnName("InvestTerm");
			this.Property(t => t.EnterpriseType).HasColumnName("EnterpriseType");
			this.Property(t => t.InvolvedStock).HasColumnName("InvolvedStock");
			this.Property(t => t.BackgroundIntro).HasColumnName("BackgroundIntro");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.IfExisted).HasColumnName("IfExisted");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

