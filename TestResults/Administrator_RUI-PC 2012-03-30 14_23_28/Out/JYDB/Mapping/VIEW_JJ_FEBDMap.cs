using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_FEBDMap : EntityTypeConfiguration<VIEW_JJ_FEBD>
	{
		public VIEW_JJ_FEBDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.StatPeriod)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_FEBD");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.StatPeriod).HasColumnName("StatPeriod");
			this.Property(t => t.StartShares).HasColumnName("StartShares");
			this.Property(t => t.ApplyingShares).HasColumnName("ApplyingShares");
			this.Property(t => t.RedeemShares).HasColumnName("RedeemShares");
			this.Property(t => t.EndShares).HasColumnName("EndShares");
			this.Property(t => t.FloatShares).HasColumnName("FloatShares");
			this.Property(t => t.DividendReinvestment).HasColumnName("DividendReinvestment");
			this.Property(t => t.ShgiftIn).HasColumnName("ShgiftIn");
			this.Property(t => t.ShiftOut).HasColumnName("ShiftOut");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.FXRCY).HasColumnName("FXRCY");
		}
	}
}

