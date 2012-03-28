using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_WarrantTradeMap : EntityTypeConfiguration<LC_WarrantTrade>
	{
		public LC_WarrantTradeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Statement)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_WarrantTrade");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
			this.Property(t => t.Circulation).HasColumnName("Circulation");
			this.Property(t => t.ExercisePrice).HasColumnName("ExercisePrice");
			this.Property(t => t.ExerciseRate).HasColumnName("ExerciseRate");
			this.Property(t => t.ExercisedWarrant).HasColumnName("ExercisedWarrant");
			this.Property(t => t.ExercisedShare).HasColumnName("ExercisedShare");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.CreationCirculation).HasColumnName("CreationCirculation");
			this.Property(t => t.ExercisedSharesAdded).HasColumnName("ExercisedSharesAdded");
			this.Property(t => t.ExercisedSharesCurrent).HasColumnName("ExercisedSharesCurrent");
			this.Property(t => t.NonListedShares).HasColumnName("NonListedShares");
		}
	}
}

