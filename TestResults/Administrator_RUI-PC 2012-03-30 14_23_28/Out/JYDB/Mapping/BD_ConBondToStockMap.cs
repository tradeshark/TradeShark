using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_ConBondToStockMap : EntityTypeConfiguration<BD_ConBondToStock>
	{
		public BD_ConBondToStockMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BD_ConBondToStock");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IssueAmount).HasColumnName("IssueAmount");
			this.Property(t => t.TotalAmountConverted).HasColumnName("TotalAmountConverted");
			this.Property(t => t.TotalVolConverted).HasColumnName("TotalVolConverted");
			this.Property(t => t.RemainingAmount).HasColumnName("RemainingAmount");
			this.Property(t => t.CurrentTotalShares).HasColumnName("CurrentTotalShares");
			this.Property(t => t.AmountConvertedThisPeriod).HasColumnName("AmountConvertedThisPeriod");
			this.Property(t => t.VolConvertedThisPeriod).HasColumnName("VolConvertedThisPeriod");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

