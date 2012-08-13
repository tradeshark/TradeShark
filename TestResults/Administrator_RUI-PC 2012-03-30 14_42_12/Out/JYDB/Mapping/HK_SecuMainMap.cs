using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_SecuMainMap : EntityTypeConfiguration<HK_SecuMain>
	{
		public HK_SecuMainMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.SecuCode)
				.HasMaxLength(10);
				
			this.Property(t => t.ChiName)
				.HasMaxLength(200);
				
			this.Property(t => t.ChiNameAbbr)
				.HasMaxLength(100);
				
			this.Property(t => t.EngName)
				.HasMaxLength(200);
				
			this.Property(t => t.EngNameAbbr)
				.HasMaxLength(50);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.ChiSpelling)
				.HasMaxLength(10);
				
			this.Property(t => t.ISIN)
				.HasMaxLength(20);
				
			this.Property(t => t.FormerName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("HK_SecuMain");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.ChiName).HasColumnName("ChiName");
			this.Property(t => t.ChiNameAbbr).HasColumnName("ChiNameAbbr");
			this.Property(t => t.EngName).HasColumnName("EngName");
			this.Property(t => t.EngNameAbbr).HasColumnName("EngNameAbbr");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.ChiSpelling).HasColumnName("ChiSpelling");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.SecuCategory).HasColumnName("SecuCategory");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.ListedSector).HasColumnName("ListedSector");
			this.Property(t => t.ListedState).HasColumnName("ListedState");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DelistingDate).HasColumnName("DelistingDate");
			this.Property(t => t.ISIN).HasColumnName("ISIN");
			this.Property(t => t.FormerName).HasColumnName("FormerName");
			this.Property(t => t.TradingUnit).HasColumnName("TradingUnit");
		}
	}
}

