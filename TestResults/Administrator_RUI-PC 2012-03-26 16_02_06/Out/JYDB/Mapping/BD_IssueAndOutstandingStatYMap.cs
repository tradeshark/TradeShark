using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_IssueAndOutstandingStatYMap : EntityTypeConfiguration<BD_IssueAndOutstandingStatY>
	{
		public BD_IssueAndOutstandingStatYMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.Year, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.Year)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("BD_IssueAndOutstandingStatY");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.Year).HasColumnName("Year");
			this.Property(t => t.IssueSizeGov).HasColumnName("IssueSizeGov");
			this.Property(t => t.IssueSizeGovReg).HasColumnName("IssueSizeGovReg");
			this.Property(t => t.IssueSizeGovCertif).HasColumnName("IssueSizeGovCertif");
			this.Property(t => t.IssueSizeGovPhysic).HasColumnName("IssueSizeGovPhysic");
			this.Property(t => t.IssueSizeGovOther).HasColumnName("IssueSizeGovOther");
			this.Property(t => t.IssueSizeGovRegFixed).HasColumnName("IssueSizeGovRegFixed");
			this.Property(t => t.IssueSizeGovRegFloat).HasColumnName("IssueSizeGovRegFloat");
			this.Property(t => t.IssueSizeGovRegDis).HasColumnName("IssueSizeGovRegDis");
			this.Property(t => t.IssueSizeGovRegCoupon).HasColumnName("IssueSizeGovRegCoupon");
			this.Property(t => t.IssueSizeGovRegAcc).HasColumnName("IssueSizeGovRegAcc");
			this.Property(t => t.IssueSizeGovRegZeroCoupon).HasColumnName("IssueSizeGovRegZeroCoupon");
			this.Property(t => t.RedemptionAndIntPayGov).HasColumnName("RedemptionAndIntPayGov");
			this.Property(t => t.IssueSizeTreasNotes).HasColumnName("IssueSizeTreasNotes");
			this.Property(t => t.RedemptionTreasNotes).HasColumnName("RedemptionTreasNotes");
			this.Property(t => t.IssueSizeFin).HasColumnName("IssueSizeFin");
			this.Property(t => t.IssueSizeFinRegFixed).HasColumnName("IssueSizeFinRegFixed");
			this.Property(t => t.IssueSizeFinRegFloat).HasColumnName("IssueSizeFinRegFloat");
			this.Property(t => t.IssueSizeFinRegDis).HasColumnName("IssueSizeFinRegDis");
			this.Property(t => t.IssueSizeFinRegCoupon).HasColumnName("IssueSizeFinRegCoupon");
			this.Property(t => t.IssueSizeFinRegAcc).HasColumnName("IssueSizeFinRegAcc");
			this.Property(t => t.IssueSizeFinRegZeroCoupon).HasColumnName("IssueSizeFinRegZeroCoupon");
			this.Property(t => t.IssueSizeCor).HasColumnName("IssueSizeCor");
			this.Property(t => t.IssueSizeCorRegFixed).HasColumnName("IssueSizeCorRegFixed");
			this.Property(t => t.IssueSizeCorRegFloat).HasColumnName("IssueSizeCorRegFloat");
			this.Property(t => t.IssueSizeConvertibleBond).HasColumnName("IssueSizeConvertibleBond");
			this.Property(t => t.NumberConvertibleBond).HasColumnName("NumberConvertibleBond");
			this.Property(t => t.OutstandingGov).HasColumnName("OutstandingGov");
			this.Property(t => t.OutstandingFin).HasColumnName("OutstandingFin");
			this.Property(t => t.OutstandingTreasNotes).HasColumnName("OutstandingTreasNotes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

