using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FundTradeInfoMap : EntityTypeConfiguration<MF_FundTradeInfo>
	{
		public MF_FundTradeInfoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("MF_FundTradeInfo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BuyingCost).HasColumnName("BuyingCost");
			this.Property(t => t.SellingIncome).HasColumnName("SellingIncome");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

