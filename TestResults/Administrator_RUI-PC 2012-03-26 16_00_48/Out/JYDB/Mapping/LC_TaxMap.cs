using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_TaxMap : EntityTypeConfiguration<LC_Tax>
	{
		public LC_TaxMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_Tax");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.VATRate).HasColumnName("VATRate");
			this.Property(t => t.VATNote).HasColumnName("VATNote");
			this.Property(t => t.SalesTaxRateCeiling).HasColumnName("SalesTaxRateCeiling");
			this.Property(t => t.SalesTaxRateFloor).HasColumnName("SalesTaxRateFloor");
			this.Property(t => t.SalesTaxNote).HasColumnName("SalesTaxNote");
			this.Property(t => t.CityPlanningTaxRate).HasColumnName("CityPlanningTaxRate");
			this.Property(t => t.CityPlanningTaxNote).HasColumnName("CityPlanningTaxNote");
			this.Property(t => t.EducationSurTaxRate).HasColumnName("EducationSurTaxRate");
			this.Property(t => t.EducationSurTaxNote).HasColumnName("EducationSurTaxNote");
			this.Property(t => t.EnterpriseIncomeTaxRate).HasColumnName("EnterpriseIncomeTaxRate");
			this.Property(t => t.RefundRatio).HasColumnName("RefundRatio");
			this.Property(t => t.ActualRate).HasColumnName("ActualRate");
			this.Property(t => t.EITaxNote).HasColumnName("EITaxNote");
			this.Property(t => t.HousePropertyTaxRate).HasColumnName("HousePropertyTaxRate");
			this.Property(t => t.HousePropertyTaxNote).HasColumnName("HousePropertyTaxNote");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

