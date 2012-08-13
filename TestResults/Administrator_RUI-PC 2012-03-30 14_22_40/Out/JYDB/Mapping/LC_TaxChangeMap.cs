using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_TaxChangeMap : EntityTypeConfiguration<LC_TaxChange>
	{
		public LC_TaxChangeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ActionDesc)
				.HasMaxLength(200);
				
			this.Property(t => t.NewestAdvance)
				.HasMaxLength(200);
				
			this.Property(t => t.SubjectName)
				.HasMaxLength(100);
				
			this.Property(t => t.ObjectName)
				.HasMaxLength(100);
				
			this.Property(t => t.Note)
				.HasMaxLength(300);
				
			this.Property(t => t.TaxChangeObject)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_TaxChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AnnouncementType).HasColumnName("AnnouncementType");
			this.Property(t => t.DisclosureMethod).HasColumnName("DisclosureMethod");
			this.Property(t => t.EventContent).HasColumnName("EventContent");
			this.Property(t => t.ActionDesc).HasColumnName("ActionDesc");
			this.Property(t => t.NewestAdvance).HasColumnName("NewestAdvance");
			this.Property(t => t.EventSubject).HasColumnName("EventSubject");
			this.Property(t => t.EventProcedure).HasColumnName("EventProcedure");
			this.Property(t => t.ActionWays).HasColumnName("ActionWays");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.SubjectName).HasColumnName("SubjectName");
			this.Property(t => t.SubjectCode).HasColumnName("SubjectCode");
			this.Property(t => t.SubjectAssociation).HasColumnName("SubjectAssociation");
			this.Property(t => t.ObjectName).HasColumnName("ObjectName");
			this.Property(t => t.ObjectCode).HasColumnName("ObjectCode");
			this.Property(t => t.ObjectAssociation).HasColumnName("ObjectAssociation");
			this.Property(t => t.AgreementDate).HasColumnName("AgreementDate");
			this.Property(t => t.IfEnded).HasColumnName("IfEnded");
			this.Property(t => t.Note).HasColumnName("Note");
			this.Property(t => t.TaxType).HasColumnName("TaxType");
			this.Property(t => t.TaxChangeObject).HasColumnName("TaxChangeObject");
			this.Property(t => t.ObjectType).HasColumnName("ObjectType");
			this.Property(t => t.TaxRatePreChange).HasColumnName("TaxRatePreChange");
			this.Property(t => t.TaxRateAfterChange).HasColumnName("TaxRateAfterChange");
			this.Property(t => t.TaxFavorMethod).HasColumnName("TaxFavorMethod");
			this.Property(t => t.ImplementTerm).HasColumnName("ImplementTerm");
			this.Property(t => t.ImplementTermBeginDate).HasColumnName("ImplementTermBeginDate");
			this.Property(t => t.ImplementTermEndDate).HasColumnName("ImplementTermEndDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

