using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_AccountReceivableMap : EntityTypeConfiguration<View_GP_AccountReceivable>
	{
		public View_GP_AccountReceivableMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_AccountReceivable");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Amount0_1).HasColumnName("Amount0_1");
			this.Property(t => t.BadDebtProvision0_1).HasColumnName("BadDebtProvision0_1");
			this.Property(t => t.Amount1_2).HasColumnName("Amount1_2");
			this.Property(t => t.BadDebtProvision1_2).HasColumnName("BadDebtProvision1_2");
			this.Property(t => t.Amount2_3).HasColumnName("Amount2_3");
			this.Property(t => t.BadDebtProvision2_3).HasColumnName("BadDebtProvision2_3");
			this.Property(t => t.Amount3).HasColumnName("Amount3");
			this.Property(t => t.BadDebtProvision3).HasColumnName("BadDebtProvision3");
			this.Property(t => t.Amount3_4).HasColumnName("Amount3_4");
			this.Property(t => t.BadDebtProvision3_4).HasColumnName("BadDebtProvision3_4");
			this.Property(t => t.Amount4_5).HasColumnName("Amount4_5");
			this.Property(t => t.BadDebtProvision4_5).HasColumnName("BadDebtProvision4_5");
			this.Property(t => t.Amount5).HasColumnName("Amount5");
			this.Property(t => t.BadDebtProvision5).HasColumnName("BadDebtProvision5");
			this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
			this.Property(t => t.TotalBadDebtProvision).HasColumnName("TotalBadDebtProvision");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

