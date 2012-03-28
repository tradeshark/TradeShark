using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_IssueAndListAgentMap : EntityTypeConfiguration<LC_IssueAndListAgent>
	{
		public LC_IssueAndListAgentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.FullName)
				.HasMaxLength(200);
				
			this.Property(t => t.AbbrName)
				.HasMaxLength(30);
				
			this.Property(t => t.LegalPersonRepr)
				.HasMaxLength(20);
				
			this.Property(t => t.Address)
				.HasMaxLength(200);
				
			this.Property(t => t.Code)
				.HasMaxLength(10);
				
			this.Property(t => t.Website)
				.HasMaxLength(100);
				
			this.Property(t => t.Email)
				.HasMaxLength(50);
				
			this.Property(t => t.Tel)
				.HasMaxLength(50);
				
			this.Property(t => t.Fax)
				.HasMaxLength(50);
				
			this.Property(t => t.Contactman)
				.HasMaxLength(200);
				
			this.Property(t => t.PersonInCharge)
				.HasMaxLength(200);
				
			this.Property(t => t.Representative)
				.HasMaxLength(100);
				
			this.Property(t => t.Remark)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_IssueAndListAgent");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.IssueAndListType).HasColumnName("IssueAndListType");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AgentType).HasColumnName("AgentType");
			this.Property(t => t.AgentCode).HasColumnName("AgentCode");
			this.Property(t => t.FullName).HasColumnName("FullName");
			this.Property(t => t.AbbrName).HasColumnName("AbbrName");
			this.Property(t => t.LegalPersonRepr).HasColumnName("LegalPersonRepr");
			this.Property(t => t.Address).HasColumnName("Address");
			this.Property(t => t.Code).HasColumnName("Code");
			this.Property(t => t.Website).HasColumnName("Website");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.Tel).HasColumnName("Tel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.Contactman).HasColumnName("Contactman");
			this.Property(t => t.PersonInCharge).HasColumnName("PersonInCharge");
			this.Property(t => t.UnderwritingVol).HasColumnName("UnderwritingVol");
			this.Property(t => t.UnderwritingSum).HasColumnName("UnderwritingSum");
			this.Property(t => t.UnderwritingRatio).HasColumnName("UnderwritingRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.AgentData).HasColumnName("AgentData");
			this.Property(t => t.Representative).HasColumnName("Representative");
			this.Property(t => t.IfEffected).HasColumnName("IfEffected");
			this.Property(t => t.CancelDate).HasColumnName("CancelDate");
			this.Property(t => t.Remark).HasColumnName("Remark");
		}
	}
}

