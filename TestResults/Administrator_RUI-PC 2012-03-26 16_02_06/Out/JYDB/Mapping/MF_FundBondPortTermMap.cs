using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FundBondPortTermMap : EntityTypeConfiguration<MF_FundBondPortTerm>
	{
		public MF_FundBondPortTermMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MF_FundBondPortTerm");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AverageTermToMaturity).HasColumnName("AverageTermToMaturity");
			this.Property(t => t.TermARateOfNetValue).HasColumnName("TermARateOfNetValue");
			this.Property(t => t.TermBRateOfNetValue).HasColumnName("TermBRateOfNetValue");
			this.Property(t => t.TermCRateOfNetValue).HasColumnName("TermCRateOfNetValue");
			this.Property(t => t.TermDRateOfNetValue).HasColumnName("TermDRateOfNetValue");
			this.Property(t => t.TermERateOfNetValue).HasColumnName("TermERateOfNetValue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DebtARateOfNetValue).HasColumnName("DebtARateOfNetValue");
			this.Property(t => t.DebtBRateOfNetValue).HasColumnName("DebtBRateOfNetValue");
			this.Property(t => t.DebtCRateOfNetValue).HasColumnName("DebtCRateOfNetValue");
			this.Property(t => t.DebtDRateOfNetValue).HasColumnName("DebtDRateOfNetValue");
			this.Property(t => t.DebtERateOfNetValue).HasColumnName("DebtERateOfNetValue");
			this.Property(t => t.FRNRefARateOfNetValue).HasColumnName("FRNRefARateOfNetValue");
			this.Property(t => t.FRNRefBRateOfNetValue).HasColumnName("FRNRefBRateOfNetValue");
			this.Property(t => t.FRNRefCRateOfNetValue).HasColumnName("FRNRefCRateOfNetValue");
			this.Property(t => t.FRNRefDRateOfNetValue).HasColumnName("FRNRefDRateOfNetValue");
			this.Property(t => t.FRNRefERateOfNetValue).HasColumnName("FRNRefERateOfNetValue");
			this.Property(t => t.FRNRefDebtARateOfNetValue).HasColumnName("FRNRefDebtARateOfNetValue");
			this.Property(t => t.FRNRefDebtBRateOfNetValue).HasColumnName("FRNRefDebtBRateOfNetValue");
			this.Property(t => t.FRNRefDebtCRateOfNetValue).HasColumnName("FRNRefDebtCRateOfNetValue");
			this.Property(t => t.FRNRefDebtDRateOfNetValue).HasColumnName("FRNRefDebtDRateOfNetValue");
			this.Property(t => t.FRNRefDebtERateOfNetValue).HasColumnName("FRNRefDebtERateOfNetValue");
		}
	}
}

