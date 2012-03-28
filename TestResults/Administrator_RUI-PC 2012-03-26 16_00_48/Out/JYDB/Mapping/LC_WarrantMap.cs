using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_WarrantMap : EntityTypeConfiguration<LC_Warrant>
	{
		public LC_WarrantMap()
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
				
			this.Property(t => t.GuarantorCompany)
				.HasMaxLength(50);
				
			this.Property(t => t.GuaranteeAsset)
				.HasMaxLength(100);
				
			this.Property(t => t.SecuredParty)
				.HasMaxLength(50);
				
			this.Property(t => t.CounterGuarantor)
				.HasMaxLength(50);
				
			this.Property(t => t.CGuaranteeAsset)
				.HasMaxLength(100);
				
			this.Property(t => t.LendBank)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_Warrant");
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
			this.Property(t => t.GuaranteeReason).HasColumnName("GuaranteeReason");
			this.Property(t => t.FirstGuaranteeSum).HasColumnName("FirstGuaranteeSum");
			this.Property(t => t.LatestGuaranteeSum).HasColumnName("LatestGuaranteeSum");
			this.Property(t => t.GuarantorCompany).HasColumnName("GuarantorCompany");
			this.Property(t => t.GuarantorAssociation).HasColumnName("GuarantorAssociation");
			this.Property(t => t.GuaranteeAsset).HasColumnName("GuaranteeAsset");
			this.Property(t => t.SecuredParty).HasColumnName("SecuredParty");
			this.Property(t => t.SecuredPartyAssociation).HasColumnName("SecuredPartyAssociation");
			this.Property(t => t.CounterGuarantor).HasColumnName("CounterGuarantor");
			this.Property(t => t.CGuarantorAssociation).HasColumnName("CGuarantorAssociation");
			this.Property(t => t.CGuaranteeAsset).HasColumnName("CGuaranteeAsset");
			this.Property(t => t.LendBank).HasColumnName("LendBank");
			this.Property(t => t.LendTerm).HasColumnName("LendTerm");
			this.Property(t => t.RenewalTerm).HasColumnName("RenewalTerm");
			this.Property(t => t.LendBeginDate).HasColumnName("LendBeginDate");
			this.Property(t => t.LendEndDate).HasColumnName("LendEndDate");
			this.Property(t => t.GuaranteeTerm).HasColumnName("GuaranteeTerm");
			this.Property(t => t.RenewalGuaranteeTerm).HasColumnName("RenewalGuaranteeTerm");
			this.Property(t => t.GuaranteeBeginDate).HasColumnName("GuaranteeBeginDate");
			this.Property(t => t.GuaranteeEndDate).HasColumnName("GuaranteeEndDate");
			this.Property(t => t.DischargeGuaranteeDate).HasColumnName("DischargeGuaranteeDate");
			this.Property(t => t.DischargeGuaranteeWays).HasColumnName("DischargeGuaranteeWays");
			this.Property(t => t.IfIllegality).HasColumnName("IfIllegality");
			this.Property(t => t.IfOverdue).HasColumnName("IfOverdue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

