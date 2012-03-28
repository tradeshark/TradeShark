using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_LongTermInvMap : EntityTypeConfiguration<LC_LongTermInv>
	{
		public LC_LongTermInvMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.DataType, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DataType)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_LongTermInv");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.LongTermEquityInv).HasColumnName("LongTermEquityInv");
			this.Property(t => t.Stock).HasColumnName("Stock");
			this.Property(t => t.SubsidiaryCompany).HasColumnName("SubsidiaryCompany");
			this.Property(t => t.JointVentureM).HasColumnName("JointVentureM");
			this.Property(t => t.JointVentureH).HasColumnName("JointVentureH");
			this.Property(t => t.OtherEquityInv).HasColumnName("OtherEquityInv");
			this.Property(t => t.ConsolidationDifference).HasColumnName("ConsolidationDifference");
			this.Property(t => t.EquityInvDifference).HasColumnName("EquityInvDifference");
			this.Property(t => t.LongTermInvOnBonds).HasColumnName("LongTermInvOnBonds");
			this.Property(t => t.OtherLongTermInv).HasColumnName("OtherLongTermInv");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

