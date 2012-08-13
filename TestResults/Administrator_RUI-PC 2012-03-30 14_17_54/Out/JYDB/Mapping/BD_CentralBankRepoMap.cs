using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_CentralBankRepoMap : EntityTypeConfiguration<BD_CentralBankRepo>
	{
		public BD_CentralBankRepoMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TradingDay, t.RepurchaseVariety, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.RepurchaseVariety)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_CentralBankRepo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.RepurchaseVariety).HasColumnName("RepurchaseVariety");
			this.Property(t => t.RepurchaseType).HasColumnName("RepurchaseType");
			this.Property(t => t.RepurchaseMethod).HasColumnName("RepurchaseMethod");
			this.Property(t => t.RepurchaseDays).HasColumnName("RepurchaseDays");
			this.Property(t => t.TenderRate).HasColumnName("TenderRate");
			this.Property(t => t.TenderSize).HasColumnName("TenderSize");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

