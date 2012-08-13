using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MT_TargetSecuritiesMap : EntityTypeConfiguration<MT_TargetSecurities>
	{
		public MT_TargetSecuritiesMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InDate, t.TargetCategory, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.TargetCategory)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChangeReasonDesc)
				.HasMaxLength(2000);
				
			// Table & Column Mappings
			this.ToTable("MT_TargetSecurities");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InDate).HasColumnName("InDate");
			this.Property(t => t.OutDate).HasColumnName("OutDate");
			this.Property(t => t.TargetCategory).HasColumnName("TargetCategory");
			this.Property(t => t.TargetFlag).HasColumnName("TargetFlag");
			this.Property(t => t.ChangeReasonDesc).HasColumnName("ChangeReasonDesc");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

