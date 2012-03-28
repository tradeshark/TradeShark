using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_ZQ_JBXXMap : EntityTypeConfiguration<VIEW_ZQ_JBXX>
	{
		public VIEW_ZQ_JBXXMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_Call, t.N_Put, t.ID, t.InnerCode, t.XGRQ });

			// Properties
			this.Property(t => t.N_BondForm)
				.HasMaxLength(300);
				
			this.Property(t => t.N_BondNature)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssuerNature)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Call)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.N_Put)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.N_CompoundMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IntPaymentMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_FRNBenchmarkRateState)
				.HasMaxLength(300);
				
			this.Property(t => t.N_UnderwritingMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_GuarantMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Issuer)
				.HasMaxLength(200);
				
			this.Property(t => t.GuarantStatement)
				.HasMaxLength(500);
				
			this.Property(t => t.CreditRating)
				.HasMaxLength(50);
				
			this.Property(t => t.FRNBenchmarkRateState)
				.HasMaxLength(200);
				
			this.Property(t => t.IntPaymentDescription)
				.HasMaxLength(300);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(500);
				
			this.Property(t => t.TradingUnit)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("VIEW_ZQ_JBXX");
			this.Property(t => t.N_BondForm).HasColumnName("N_BondForm");
			this.Property(t => t.N_BondNature).HasColumnName("N_BondNature");
			this.Property(t => t.N_IssuerNature).HasColumnName("N_IssuerNature");
			this.Property(t => t.N_Call).HasColumnName("N_Call");
			this.Property(t => t.N_Put).HasColumnName("N_Put");
			this.Property(t => t.N_CompoundMethod).HasColumnName("N_CompoundMethod");
			this.Property(t => t.N_IntPaymentMethod).HasColumnName("N_IntPaymentMethod");
			this.Property(t => t.N_FRNBenchmarkRateState).HasColumnName("N_FRNBenchmarkRateState");
			this.Property(t => t.N_UnderwritingMethod).HasColumnName("N_UnderwritingMethod");
			this.Property(t => t.N_GuarantMethod).HasColumnName("N_GuarantMethod");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.BondForm).HasColumnName("BondForm");
			this.Property(t => t.BondNature).HasColumnName("BondNature");
			this.Property(t => t.Issuer).HasColumnName("Issuer");
			this.Property(t => t.IssuerNature).HasColumnName("IssuerNature");
			this.Property(t => t.GuarantMethod).HasColumnName("GuarantMethod");
			this.Property(t => t.GuarantStatement).HasColumnName("GuarantStatement");
			this.Property(t => t.CreditRating).HasColumnName("CreditRating");
			this.Property(t => t.Maturity).HasColumnName("Maturity");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Call).HasColumnName("Call");
			this.Property(t => t.Put).HasColumnName("Put");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.CompoundMethod).HasColumnName("CompoundMethod");
			this.Property(t => t.IntPaymentMethod).HasColumnName("IntPaymentMethod");
			this.Property(t => t.CouponFreq).HasColumnName("CouponFreq");
			this.Property(t => t.CouponRate).HasColumnName("CouponRate");
			this.Property(t => t.FRNMargin).HasColumnName("FRNMargin");
			this.Property(t => t.IncrsCouponMargin).HasColumnName("IncrsCouponMargin");
			this.Property(t => t.FRNBenchmarkRateState).HasColumnName("FRNBenchmarkRateState");
			this.Property(t => t.MinAnnualRate).HasColumnName("MinAnnualRate");
			this.Property(t => t.InflationSubsidy).HasColumnName("InflationSubsidy");
			this.Property(t => t.InterestTaxRate).HasColumnName("InterestTaxRate");
			this.Property(t => t.IntPaymentDescription).HasColumnName("IntPaymentDescription");
			this.Property(t => t.MaturityDate).HasColumnName("MaturityDate");
			this.Property(t => t.RedemptionPrice).HasColumnName("RedemptionPrice");
			this.Property(t => t.RedemptionRegDate).HasColumnName("RedemptionRegDate");
			this.Property(t => t.RedemptionClearingDate).HasColumnName("RedemptionClearingDate");
			this.Property(t => t.RedemptionStartDate).HasColumnName("RedemptionStartDate");
			this.Property(t => t.RedemptionEndDate).HasColumnName("RedemptionEndDate");
			this.Property(t => t.BulletinDate).HasColumnName("BulletinDate");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.UnderwritingMethod).HasColumnName("UnderwritingMethod");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.ValueDate).HasColumnName("ValueDate");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.SubscriptionUnit).HasColumnName("SubscriptionUnit");
			this.Property(t => t.IssueSizePlanned).HasColumnName("IssueSizePlanned");
			this.Property(t => t.PlannedAddedIssue).HasColumnName("PlannedAddedIssue");
			this.Property(t => t.ActualIssuSize).HasColumnName("ActualIssuSize");
			this.Property(t => t.ActualAddedIssue).HasColumnName("ActualAddedIssue");
			this.Property(t => t.ActualAddedStartDate).HasColumnName("ActualAddedStartDate");
			this.Property(t => t.ActualAddedEndDate).HasColumnName("ActualAddedEndDate");
			this.Property(t => t.ActualAddedListedDate).HasColumnName("ActualAddedListedDate");
			this.Property(t => t.ListAnnouncementIssueDate).HasColumnName("ListAnnouncementIssueDate");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.TradingUnit).HasColumnName("TradingUnit");
			this.Property(t => t.TradingUnitParValue).HasColumnName("TradingUnitParValue");
			this.Property(t => t.DelistDate).HasColumnName("DelistDate");
			this.Property(t => t.IssueCommissionRate).HasColumnName("IssueCommissionRate");
			this.Property(t => t.RedemptionCommissionRate).HasColumnName("RedemptionCommissionRate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

