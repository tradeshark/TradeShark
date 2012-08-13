using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_BuybackMap : EntityTypeConfiguration<LC_Buyback>
	{
		public LC_BuybackMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.FirstPublDate, t.ShareType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ShareType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Seller)
				.HasMaxLength(100);
				
			this.Property(t => t.PricingStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_Buyback");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.FirstPublDate).HasColumnName("FirstPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ShareType).HasColumnName("ShareType");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.MeetPassDate).HasColumnName("MeetPassDate");
			this.Property(t => t.WriteOffPublDate).HasColumnName("WriteOffPublDate");
			this.Property(t => t.ContractDate).HasColumnName("ContractDate");
			this.Property(t => t.Seller).HasColumnName("Seller");
			this.Property(t => t.BuybackSum).HasColumnName("BuybackSum");
			this.Property(t => t.Percentage).HasColumnName("Percentage");
			this.Property(t => t.PricingStatement).HasColumnName("PricingStatement");
			this.Property(t => t.BuybackPrice).HasColumnName("BuybackPrice");
			this.Property(t => t.BuybackMoney).HasColumnName("BuybackMoney");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.PayMode).HasColumnName("PayMode");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.PayDate).HasColumnName("PayDate");
			this.Property(t => t.ChangeRegDate).HasColumnName("ChangeRegDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

