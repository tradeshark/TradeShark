using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_SSFEquityChangeMap : EntityTypeConfiguration<ED_SSFEquityChange>
	{
		public ED_SSFEquityChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.IfAdjusted, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("ED_SSFEquityChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.BeginningEquityBalance).HasColumnName("BeginningEquityBalance");
			this.Property(t => t.FundsPayIn).HasColumnName("FundsPayIn");
			this.Property(t => t.FundsPayOut).HasColumnName("FundsPayOut");
			this.Property(t => t.EquityChangeByPayInOrOut).HasColumnName("EquityChangeByPayInOrOut");
			this.Property(t => t.OperRevenue).HasColumnName("OperRevenue");
			this.Property(t => t.OperExpenditure).HasColumnName("OperExpenditure");
			this.Property(t => t.EquityChangeByOper).HasColumnName("EquityChangeByOper");
			this.Property(t => t.OtherEquityChanges).HasColumnName("OtherEquityChanges");
			this.Property(t => t.EndingEquityBalance).HasColumnName("EndingEquityBalance");
			this.Property(t => t.RiskReserveBalance).HasColumnName("RiskReserveBalance");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

