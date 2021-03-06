using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_InitiatorHoldingMap : EntityTypeConfiguration<MF_InitiatorHolding>
	{
		public MF_InitiatorHoldingMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InitiatorName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.InitiatorName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.InitiatorCode)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("MF_InitiatorHolding");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.FundTotalVolume).HasColumnName("FundTotalVolume");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
			this.Property(t => t.InitiatorCode).HasColumnName("InitiatorCode");
			this.Property(t => t.HoldingShares).HasColumnName("HoldingShares");
			this.Property(t => t.HoldingRatio).HasColumnName("HoldingRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

