using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_IssueAndListAgentMap : EntityTypeConfiguration<HK_IssueAndListAgent>
	{
		public HK_IssueAndListAgentMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.AgentTypeName)
				.HasMaxLength(100);
				
			this.Property(t => t.AgentName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("HK_IssueAndListAgent");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.IssueType).HasColumnName("IssueType");
			this.Property(t => t.AgentTypeName).HasColumnName("AgentTypeName");
			this.Property(t => t.AgentType).HasColumnName("AgentType");
			this.Property(t => t.AgentName).HasColumnName("AgentName");
			this.Property(t => t.AgentCode).HasColumnName("AgentCode");
			this.Property(t => t.IfEffected).HasColumnName("IfEffected");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

