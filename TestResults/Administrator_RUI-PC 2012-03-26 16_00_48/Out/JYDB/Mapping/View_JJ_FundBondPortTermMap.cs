using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_FundBondPortTermMap : EntityTypeConfiguration<View_JJ_FundBondPortTerm>
	{
		public View_JJ_FundBondPortTermMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.JSID, t.XGRQ });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_FundBondPortTerm");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.AverageTermToMaturity).HasColumnName("AverageTermToMaturity");
			this.Property(t => t.TermARateOfNetValue).HasColumnName("TermARateOfNetValue");
			this.Property(t => t.TermBRateOfNetValue).HasColumnName("TermBRateOfNetValue");
			this.Property(t => t.TermCRateOfNetValue).HasColumnName("TermCRateOfNetValue");
			this.Property(t => t.TermDRateOfNetValue).HasColumnName("TermDRateOfNetValue");
			this.Property(t => t.TermERateOfNetValue).HasColumnName("TermERateOfNetValue");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

