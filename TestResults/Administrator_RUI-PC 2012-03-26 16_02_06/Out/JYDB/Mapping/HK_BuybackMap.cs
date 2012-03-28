using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_BuybackMap : EntityTypeConfiguration<HK_Buyback>
	{
		public HK_BuybackMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ShareType)
				.HasMaxLength(50);
				
			this.Property(t => t.ParValueUnit)
				.HasMaxLength(50);
				
			this.Property(t => t.MethodStatement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_Buyback");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.PublDate).HasColumnName("PublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ShareTypeCode).HasColumnName("ShareTypeCode");
			this.Property(t => t.ShareType).HasColumnName("ShareType");
			this.Property(t => t.ParValueCode).HasColumnName("ParValueCode");
			this.Property(t => t.ParValueUnit).HasColumnName("ParValueUnit");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.BuybackSum).HasColumnName("BuybackSum");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.BuybackMoney).HasColumnName("BuybackMoney");
			this.Property(t => t.CumulativeSum).HasColumnName("CumulativeSum");
			this.Property(t => t.CumulativeSumToTS).HasColumnName("CumulativeSumToTS");
			this.Property(t => t.MethodStatement).HasColumnName("MethodStatement");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

