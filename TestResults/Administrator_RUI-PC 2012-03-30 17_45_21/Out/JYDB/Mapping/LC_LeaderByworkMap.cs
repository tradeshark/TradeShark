using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_LeaderByworkMap : EntityTypeConfiguration<LC_LeaderBywork>
	{
		public LC_LeaderByworkMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.LeaderName, t.EnterpriseBywork, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.LeaderName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.EnterpriseBywork)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.TermState)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_LeaderBywork");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.LeaderName).HasColumnName("LeaderName");
			this.Property(t => t.Position).HasColumnName("Position");
			this.Property(t => t.EnterpriseBywork).HasColumnName("EnterpriseBywork");
			this.Property(t => t.RelaCode).HasColumnName("RelaCode");
			this.Property(t => t.ByworkPosi).HasColumnName("ByworkPosi");
			this.Property(t => t.TermState).HasColumnName("TermState");
			this.Property(t => t.StartTime).HasColumnName("StartTime");
			this.Property(t => t.EndTime).HasColumnName("EndTime");
			this.Property(t => t.IfPay).HasColumnName("IfPay");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

