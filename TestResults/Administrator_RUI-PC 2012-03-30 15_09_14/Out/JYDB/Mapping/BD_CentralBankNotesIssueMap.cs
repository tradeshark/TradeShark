using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_CentralBankNotesIssueMap : EntityTypeConfiguration<BD_CentralBankNotesIssue>
	{
		public BD_CentralBankNotesIssueMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_CentralBankNotesIssue");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.IssueDate).HasColumnName("IssueDate");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.ActualIssueSize).HasColumnName("ActualIssueSize");
			this.Property(t => t.Maturity).HasColumnName("Maturity");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.IssueRefYTM).HasColumnName("IssueRefYTM");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

