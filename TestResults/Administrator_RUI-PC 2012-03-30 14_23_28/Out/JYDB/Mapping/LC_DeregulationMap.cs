using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_DeregulationMap : EntityTypeConfiguration<LC_Deregulation>
	{
		public LC_DeregulationMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InstitutionName)
				.HasMaxLength(100);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Reason)
				.HasMaxLength(200);
				
			this.Property(t => t.RelatedParty)
				.HasMaxLength(100);
				
			this.Property(t => t.InvolvedStatute)
				.HasMaxLength(500);
				
			this.Property(t => t.Penalty)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_Deregulation");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.Subject).HasColumnName("Subject");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InstitutionCode).HasColumnName("InstitutionCode");
			this.Property(t => t.InstitutionName).HasColumnName("InstitutionName");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EventContent).HasColumnName("EventContent");
			this.Property(t => t.AdminInst).HasColumnName("AdminInst");
			this.Property(t => t.AdminObject).HasColumnName("AdminObject");
			this.Property(t => t.AdminType).HasColumnName("AdminType");
			this.Property(t => t.Reason).HasColumnName("Reason");
			this.Property(t => t.ReasonType).HasColumnName("ReasonType");
			this.Property(t => t.ContentType).HasColumnName("ContentType");
			this.Property(t => t.RelatedParty).HasColumnName("RelatedParty");
			this.Property(t => t.Association).HasColumnName("Association");
			this.Property(t => t.ComPenalSum).HasColumnName("ComPenalSum");
			this.Property(t => t.IndividualPenalSum).HasColumnName("IndividualPenalSum");
			this.Property(t => t.InstitutionPenalSum).HasColumnName("InstitutionPenalSum");
			this.Property(t => t.InvolvedStatute).HasColumnName("InvolvedStatute");
			this.Property(t => t.Penalty).HasColumnName("Penalty");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

