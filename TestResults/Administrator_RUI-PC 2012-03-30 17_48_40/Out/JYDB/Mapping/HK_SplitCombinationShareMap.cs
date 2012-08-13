using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_SplitCombinationShareMap : EntityTypeConfiguration<HK_SplitCombinationShare>
	{
		public HK_SplitCombinationShareMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.SchemeStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.TempShareCode)
				.HasMaxLength(10);
				
			this.Property(t => t.TempShareAbbrName)
				.HasMaxLength(50);
				
			this.Property(t => t.OddLotsTradeAgent)
				.HasMaxLength(200);
				
			this.Property(t => t.AgentTel)
				.HasMaxLength(50);
				
			this.Property(t => t.AgentAddr)
				.HasMaxLength(200);
				
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_SplitCombinationShare");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.DirDeciPublDate).HasColumnName("DirDeciPublDate");
			this.Property(t => t.DirDeciSignDate).HasColumnName("DirDeciSignDate");
			this.Property(t => t.SMDeciDate).HasColumnName("SMDeciDate");
			this.Property(t => t.CircularPunlDate).HasColumnName("CircularPunlDate");
			this.Property(t => t.ExpirePublDate).HasColumnName("ExpirePublDate");
			this.Property(t => t.EffectDate).HasColumnName("EffectDate");
			this.Property(t => t.SchemeStatement).HasColumnName("SchemeStatement");
			this.Property(t => t.SupplementaryType).HasColumnName("SupplementaryType");
			this.Property(t => t.Process).HasColumnName("Process");
			this.Property(t => t.ReformType).HasColumnName("ReformType");
			this.Property(t => t.CombinationX).HasColumnName("CombinationX");
			this.Property(t => t.CombinationY).HasColumnName("CombinationY");
			this.Property(t => t.SplitX).HasColumnName("SplitX");
			this.Property(t => t.SplitY).HasColumnName("SplitY");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.OldParValue).HasColumnName("OldParValue");
			this.Property(t => t.NewParValue).HasColumnName("NewParValue");
			this.Property(t => t.WriteOffBase).HasColumnName("WriteOffBase");
			this.Property(t => t.WriteOffParValue).HasColumnName("WriteOffParValue");
			this.Property(t => t.OldTradeUnit).HasColumnName("OldTradeUnit");
			this.Property(t => t.NewTradeUnit).HasColumnName("NewTradeUnit");
			this.Property(t => t.SharesIssued).HasColumnName("SharesIssued");
			this.Property(t => t.SharesAfterEffect).HasColumnName("SharesAfterEffect");
			this.Property(t => t.TempShareCode).HasColumnName("TempShareCode");
			this.Property(t => t.TempShareAbbrName).HasColumnName("TempShareAbbrName");
			this.Property(t => t.TempTradeUnit).HasColumnName("TempTradeUnit");
			this.Property(t => t.TempTradeBeginDate).HasColumnName("TempTradeBeginDate");
			this.Property(t => t.SimulTradeBeginDate).HasColumnName("SimulTradeBeginDate");
			this.Property(t => t.SimulTradeEndDate).HasColumnName("SimulTradeEndDate");
			this.Property(t => t.OddLotsTradeAgent).HasColumnName("OddLotsTradeAgent");
			this.Property(t => t.AgentCode).HasColumnName("AgentCode");
			this.Property(t => t.AgentTel).HasColumnName("AgentTel");
			this.Property(t => t.AgentAddr).HasColumnName("AgentAddr");
			this.Property(t => t.OddLotsTradeBeginDate).HasColumnName("OddLotsTradeBeginDate");
			this.Property(t => t.OddLotsTradeEndDate).HasColumnName("OddLotsTradeEndDate");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

