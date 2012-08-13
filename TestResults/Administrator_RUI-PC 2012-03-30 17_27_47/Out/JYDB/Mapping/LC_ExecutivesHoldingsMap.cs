using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ExecutivesHoldingsMap : EntityTypeConfiguration<LC_ExecutivesHoldings>
	{
		public LC_ExecutivesHoldingsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(60);
				
			this.Property(t => t.LeaderName)
				.HasMaxLength(50);
				
			this.Property(t => t.OffStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.PositionDescription)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_ExecutivesHoldings");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SequenceNumber).HasColumnName("SequenceNumber");
			this.Property(t => t.LeaderName).HasColumnName("LeaderName");
			this.Property(t => t.Position).HasColumnName("Position");
			this.Property(t => t.ShareAmount).HasColumnName("ShareAmount");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.AnnualReward).HasColumnName("AnnualReward");
			this.Property(t => t.IfIn).HasColumnName("IfIn");
			this.Property(t => t.OffStatement).HasColumnName("OffStatement");
			this.Property(t => t.PositionDescription).HasColumnName("PositionDescription");
			this.Property(t => t.ShareAmountBeginning).HasColumnName("ShareAmountBeginning");
			this.Property(t => t.IndirectShares).HasColumnName("IndirectShares");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.Subsidy).HasColumnName("Subsidy");
			this.Property(t => t.SharesExercisable).HasColumnName("SharesExercisable");
			this.Property(t => t.SharesExercised).HasColumnName("SharesExercised");
			this.Property(t => t.ExercisePrice).HasColumnName("ExercisePrice");
			this.Property(t => t.EndingMarketPrice).HasColumnName("EndingMarketPrice");
		}
	}
}

