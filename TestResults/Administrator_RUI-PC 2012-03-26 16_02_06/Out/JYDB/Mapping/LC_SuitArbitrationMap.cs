using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SuitArbitrationMap : EntityTypeConfiguration<LC_SuitArbitration>
	{
		public LC_SuitArbitrationMap()
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
				
			this.Property(t => t.Plaintiff)
				.HasMaxLength(100);
				
			this.Property(t => t.Defendant)
				.HasMaxLength(100);
				
			this.Property(t => t.JSRParty)
				.HasMaxLength(100);
				
			this.Property(t => t.OtherParty)
				.HasMaxLength(50);
				
			this.Property(t => t.SubjectMatterStat)
				.HasMaxLength(200);
				
			this.Property(t => t.InquisitionInstitute)
				.HasMaxLength(50);
				
			this.Property(t => t.PropertyEnforced)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_SuitArbitration");
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
			this.Property(t => t.FirstSuitSum).HasColumnName("FirstSuitSum");
			this.Property(t => t.LatestSuitSum).HasColumnName("LatestSuitSum");
			this.Property(t => t.Plaintiff).HasColumnName("Plaintiff");
			this.Property(t => t.PlaintiffAssociation).HasColumnName("PlaintiffAssociation");
			this.Property(t => t.Defendant).HasColumnName("Defendant");
			this.Property(t => t.DefendantAssociation).HasColumnName("DefendantAssociation");
			this.Property(t => t.JSRParty).HasColumnName("JSRParty");
			this.Property(t => t.JSRPartyAssociation).HasColumnName("JSRPartyAssociation");
			this.Property(t => t.OtherParty).HasColumnName("OtherParty");
			this.Property(t => t.OtherPartyAssociation).HasColumnName("OtherPartyAssociation");
			this.Property(t => t.SubjectMatterStat).HasColumnName("SubjectMatterStat");
			this.Property(t => t.SubjectMatter).HasColumnName("SubjectMatter");
			this.Property(t => t.EventSubjectRole).HasColumnName("EventSubjectRole");
			this.Property(t => t.InquisitionInstitute).HasColumnName("InquisitionInstitute");
			this.Property(t => t.CaseStatus).HasColumnName("CaseStatus");
			this.Property(t => t.FirstInstanceStatus).HasColumnName("FirstInstanceStatus");
			this.Property(t => t.SecondInstanceStatus).HasColumnName("SecondInstanceStatus");
			this.Property(t => t.SPPStatus).HasColumnName("SPPStatus");
			this.Property(t => t.PropertyEnforcement).HasColumnName("PropertyEnforcement");
			this.Property(t => t.PropertyEnforced).HasColumnName("PropertyEnforced");
			this.Property(t => t.PropertyBelonged).HasColumnName("PropertyBelonged");
			this.Property(t => t.AdjudgementStatus).HasColumnName("AdjudgementStatus");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

