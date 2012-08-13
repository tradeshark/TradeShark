using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_LegalDistributionMap : EntityTypeConfiguration<LC_LegalDistribution>
	{
		public LC_LegalDistributionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InfoPublDate, t.DistributionSum, t.AquirerName, t.AquiredSum, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.DistributionSum)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AquirerName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.SecuCoBelonged)
				.HasMaxLength(100);
				
			this.Property(t => t.AquiredSum)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Notes)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_LegalDistribution");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DistributionSum).HasColumnName("DistributionSum");
			this.Property(t => t.DistributionReason).HasColumnName("DistributionReason");
			this.Property(t => t.SerialNum).HasColumnName("SerialNum");
			this.Property(t => t.AquirerName).HasColumnName("AquirerName");
			this.Property(t => t.AquirerCharacter).HasColumnName("AquirerCharacter");
			this.Property(t => t.SecuCoBelongedCode).HasColumnName("SecuCoBelongedCode");
			this.Property(t => t.SecuCoBelonged).HasColumnName("SecuCoBelonged");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.AquiredSum).HasColumnName("AquiredSum");
			this.Property(t => t.OwnedPeriod).HasColumnName("OwnedPeriod");
			this.Property(t => t.DistributeNature).HasColumnName("DistributeNature");
			this.Property(t => t.FloatDate).HasColumnName("FloatDate");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.ValidApplyVol).HasColumnName("ValidApplyVol");
			this.Property(t => t.RefundAmount).HasColumnName("RefundAmount");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
		}
	}
}

