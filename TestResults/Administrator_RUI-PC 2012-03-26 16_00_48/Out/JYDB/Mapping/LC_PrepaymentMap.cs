using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PrepaymentMap : EntityTypeConfiguration<LC_Prepayment>
	{
		public LC_PrepaymentMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_Prepayment");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.Amount0_1).HasColumnName("Amount0_1");
			this.Property(t => t.Ratio0_1).HasColumnName("Ratio0_1");
			this.Property(t => t.Amount1_2).HasColumnName("Amount1_2");
			this.Property(t => t.Ratio1_2).HasColumnName("Ratio1_2");
			this.Property(t => t.Amount2_3).HasColumnName("Amount2_3");
			this.Property(t => t.Ratio2_3).HasColumnName("Ratio2_3");
			this.Property(t => t.Amount3).HasColumnName("Amount3");
			this.Property(t => t.Ratio3).HasColumnName("Ratio3");
			this.Property(t => t.Amount3_4).HasColumnName("Amount3_4");
			this.Property(t => t.Ratio3_4).HasColumnName("Ratio3_4");
			this.Property(t => t.Amount4_5).HasColumnName("Amount4_5");
			this.Property(t => t.Ratio4_5).HasColumnName("Ratio4_5");
			this.Property(t => t.Amount5).HasColumnName("Amount5");
			this.Property(t => t.Ratio5).HasColumnName("Ratio5");
			this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
			this.Property(t => t.TotalRatio).HasColumnName("TotalRatio");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AmountFromMainArrears).HasColumnName("AmountFromMainArrears");
			this.Property(t => t.RatioFromMainArrears).HasColumnName("RatioFromMainArrears");
			this.Property(t => t.AmountOfMainHolders).HasColumnName("AmountOfMainHolders");
			this.Property(t => t.RatioOfMainHolders).HasColumnName("RatioOfMainHolders");
			this.Property(t => t.AmountForRelations).HasColumnName("AmountForRelations");
			this.Property(t => t.RatioForRelations).HasColumnName("RatioForRelations");
		}
	}
}

