using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AccountReceivableMap : EntityTypeConfiguration<LC_AccountReceivable>
	{
		public LC_AccountReceivableMap()
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
			this.ToTable("LC_AccountReceivable");
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
			this.Property(t => t.Proportion0_1).HasColumnName("Proportion0_1");
			this.Property(t => t.Proportion1_2).HasColumnName("Proportion1_2");
			this.Property(t => t.ReserveWithdrawalProp1_2).HasColumnName("ReserveWithdrawalProp1_2");
			this.Property(t => t.Proportion2_3).HasColumnName("Proportion2_3");
			this.Property(t => t.ReserveWithdrawalProp2_3).HasColumnName("ReserveWithdrawalProp2_3");
			this.Property(t => t.Proportion3).HasColumnName("Proportion3");
			this.Property(t => t.ReserveWithdrawalProp3).HasColumnName("ReserveWithdrawalProp3");
			this.Property(t => t.Proportion3_4).HasColumnName("Proportion3_4");
			this.Property(t => t.ReserveWithdrawalProp3_4).HasColumnName("ReserveWithdrawalProp3_4");
			this.Property(t => t.Proportion4_5).HasColumnName("Proportion4_5");
			this.Property(t => t.ReserveWithdrawalProp4_5).HasColumnName("ReserveWithdrawalProp4_5");
			this.Property(t => t.Proportion5).HasColumnName("Proportion5");
			this.Property(t => t.ReserveWithdrawalProp5).HasColumnName("ReserveWithdrawalProp5");
			this.Property(t => t.ReserveWithdrawalPropT).HasColumnName("ReserveWithdrawalPropT");
			this.Property(t => t.AmountSignificantSingle).HasColumnName("AmountSignificantSingle");
			this.Property(t => t.PropSignificantSingle).HasColumnName("PropSignificantSingle");
			this.Property(t => t.BadDebtProvisionSS).HasColumnName("BadDebtProvisionSS");
			this.Property(t => t.ReserveWithdrawalPropSS).HasColumnName("ReserveWithdrawalPropSS");
			this.Property(t => t.AmountCreditRiskHigh).HasColumnName("AmountCreditRiskHigh");
			this.Property(t => t.PropCreditRiskHigh).HasColumnName("PropCreditRiskHigh");
			this.Property(t => t.BadDebtProvisionCRH).HasColumnName("BadDebtProvisionCRH");
			this.Property(t => t.ReserveWithdrawalPropCRH).HasColumnName("ReserveWithdrawalPropCRH");
			this.Property(t => t.AmountInsignificant).HasColumnName("AmountInsignificant");
			this.Property(t => t.PropInsignificant).HasColumnName("PropInsignificant");
			this.Property(t => t.BadDebtProvisionIS).HasColumnName("BadDebtProvisionIS");
			this.Property(t => t.ReserveWithdrawalPropIS).HasColumnName("ReserveWithdrawalPropIS");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.ReserveWithdrawalProp0_1).HasColumnName("ReserveWithdrawalProp0_1");
			this.Property(t => t.AmountFromMainArrears).HasColumnName("AmountFromMainArrears");
			this.Property(t => t.RatioFromMainArrears).HasColumnName("RatioFromMainArrears");
			this.Property(t => t.AmountOfMainHolders).HasColumnName("AmountOfMainHolders");
			this.Property(t => t.RatioOfMainHolders).HasColumnName("RatioOfMainHolders");
			this.Property(t => t.AmountForRelations).HasColumnName("AmountForRelations");
			this.Property(t => t.RatioForRelations).HasColumnName("RatioForRelations");
		}
	}
}

