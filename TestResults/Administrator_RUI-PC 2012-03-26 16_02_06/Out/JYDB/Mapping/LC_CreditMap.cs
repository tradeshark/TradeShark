using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CreditMap : EntityTypeConfiguration<LC_Credit>
	{
		public LC_CreditMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ActionDesc)
				.HasMaxLength(200);
				
			this.Property(t => t.NewestAdvance)
				.HasMaxLength(200);
				
			this.Property(t => t.SubjectName)
				.HasMaxLength(100);
				
			this.Property(t => t.ObjectName)
				.HasMaxLength(100);
				
			this.Property(t => t.Note)
				.HasMaxLength(300);
				
			this.Property(t => t.Borrower)
				.HasMaxLength(50);
				
			this.Property(t => t.MortgageAsset)
				.HasMaxLength(100);
				
			this.Property(t => t.Lender)
				.HasMaxLength(50);
				
			this.Property(t => t.Guarantor)
				.HasMaxLength(50);
				
			this.Property(t => t.GuarantorMortgageAsset)
				.HasMaxLength(100);
				
			this.Property(t => t.YearRateStat)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_Credit");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AnnouncementType).HasColumnName("AnnouncementType");
			this.Property(t => t.DisclosureMethod).HasColumnName("DisclosureMethod");
			this.Property(t => t.EventContent).HasColumnName("EventContent");
			this.Property(t => t.ActionDesc).HasColumnName("ActionDesc");
			this.Property(t => t.NewestAdvance).HasColumnName("NewestAdvance");
			this.Property(t => t.EventSubject).HasColumnName("EventSubject");
			this.Property(t => t.EventProcedure).HasColumnName("EventProcedure");
			this.Property(t => t.ActionWays).HasColumnName("ActionWays");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.SubjectName).HasColumnName("SubjectName");
			this.Property(t => t.SubjectCode).HasColumnName("SubjectCode");
			this.Property(t => t.SubjectAssociation).HasColumnName("SubjectAssociation");
			this.Property(t => t.ObjectName).HasColumnName("ObjectName");
			this.Property(t => t.ObjectCode).HasColumnName("ObjectCode");
			this.Property(t => t.ObjectAssociation).HasColumnName("ObjectAssociation");
			this.Property(t => t.AgreementDate).HasColumnName("AgreementDate");
			this.Property(t => t.IfEnded).HasColumnName("IfEnded");
			this.Property(t => t.Note).HasColumnName("Note");
			this.Property(t => t.LoanCondition).HasColumnName("LoanCondition");
			this.Property(t => t.Borrower).HasColumnName("Borrower");
			this.Property(t => t.BorrowerAssociation).HasColumnName("BorrowerAssociation");
			this.Property(t => t.MortgageAsset).HasColumnName("MortgageAsset");
			this.Property(t => t.Lender).HasColumnName("Lender");
			this.Property(t => t.LenderAssociation).HasColumnName("LenderAssociation");
			this.Property(t => t.Guarantor).HasColumnName("Guarantor");
			this.Property(t => t.GuarantorAssociation).HasColumnName("GuarantorAssociation");
			this.Property(t => t.GuarantorMortgageAsset).HasColumnName("GuarantorMortgageAsset");
			this.Property(t => t.FirstLoanSum).HasColumnName("FirstLoanSum");
			this.Property(t => t.LatestLoanSum).HasColumnName("LatestLoanSum");
			this.Property(t => t.LatestRepaymentSum).HasColumnName("LatestRepaymentSum");
			this.Property(t => t.AccumulatedRepaymentSum).HasColumnName("AccumulatedRepaymentSum");
			this.Property(t => t.YearRateStat).HasColumnName("YearRateStat");
			this.Property(t => t.YearRate).HasColumnName("YearRate");
			this.Property(t => t.LoanTerm).HasColumnName("LoanTerm");
			this.Property(t => t.RenewalTerm).HasColumnName("RenewalTerm");
			this.Property(t => t.LoanBeginDate).HasColumnName("LoanBeginDate");
			this.Property(t => t.LoanEndDate).HasColumnName("LoanEndDate");
			this.Property(t => t.LoanGuaranteeTerm).HasColumnName("LoanGuaranteeTerm");
			this.Property(t => t.LoanRenewalGuaranteeTerm).HasColumnName("LoanRenewalGuaranteeTerm");
			this.Property(t => t.LoanGuaranteeBeginDate).HasColumnName("LoanGuaranteeBeginDate");
			this.Property(t => t.LoanGuaranteeEndDate).HasColumnName("LoanGuaranteeEndDate");
			this.Property(t => t.LatestRepaymentDate).HasColumnName("LatestRepaymentDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

