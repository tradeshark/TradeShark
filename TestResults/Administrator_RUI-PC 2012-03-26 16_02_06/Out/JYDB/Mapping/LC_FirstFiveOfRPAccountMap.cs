using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FirstFiveOfRPAccountMap : EntityTypeConfiguration<LC_FirstFiveOfRPAccount>
	{
		public LC_FirstFiveOfRPAccountMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Debtor)
				.IsRequired()
				.HasMaxLength(120);
				
			this.Property(t => t.DebtTime)
				.HasMaxLength(50);
				
			this.Property(t => t.Reason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_FirstFiveOfRPAccount");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AcountType).HasColumnName("AcountType");
			this.Property(t => t.Debtor).HasColumnName("Debtor");
			this.Property(t => t.DebtSum).HasColumnName("DebtSum");
			this.Property(t => t.DebtTime).HasColumnName("DebtTime");
			this.Property(t => t.Reason).HasColumnName("Reason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

