using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_WarrantDetailsMap : EntityTypeConfiguration<MF_WarrantDetails>
	{
		public MF_WarrantDetailsMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("MF_WarrantDetails");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.InvestType).HasColumnName("InvestType");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.WarrantInnerCode).HasColumnName("WarrantInnerCode");
			this.Property(t => t.SharesHolding).HasColumnName("SharesHolding");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

