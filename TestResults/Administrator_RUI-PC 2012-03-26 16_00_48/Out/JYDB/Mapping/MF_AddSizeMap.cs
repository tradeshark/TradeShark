using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_AddSizeMap : EntityTypeConfiguration<MF_AddSize>
	{
		public MF_AddSizeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(250);
				
			this.Property(t => t.InitiatorQuotaPriceNotes)
				.HasMaxLength(250);
				
			this.Property(t => t.AbbrNameForApplying)
				.HasMaxLength(20);
				
			this.Property(t => t.ApplyingCode)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("MF_AddSize");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.ProspectusIssueDate).HasColumnName("ProspectusIssueDate");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
			this.Property(t => t.InitiatorQuotaPriceNotes).HasColumnName("InitiatorQuotaPriceNotes");
			this.Property(t => t.AddShares).HasColumnName("AddShares");
			this.Property(t => t.UnitIsuueFee).HasColumnName("UnitIsuueFee");
			this.Property(t => t.InitiatorQuota).HasColumnName("InitiatorQuota");
			this.Property(t => t.PublicQuota).HasColumnName("PublicQuota");
			this.Property(t => t.PublicQuotaRatio).HasColumnName("PublicQuotaRatio");
			this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.AbbrNameForApplying).HasColumnName("AbbrNameForApplying");
			this.Property(t => t.ApplyingCode).HasColumnName("ApplyingCode");
			this.Property(t => t.PayStartDateForPublic).HasColumnName("PayStartDateForPublic");
			this.Property(t => t.PayEndDateForPublic).HasColumnName("PayEndDateForPublic");
			this.Property(t => t.PayDateForInitiator).HasColumnName("PayDateForInitiator");
			this.Property(t => t.PayDateForBuyRest).HasColumnName("PayDateForBuyRest");
			this.Property(t => t.PayStartDateForFI).HasColumnName("PayStartDateForFI");
			this.Property(t => t.PayEndDateForFI).HasColumnName("PayEndDateForFI");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.PublicActualBuyShares).HasColumnName("PublicActualBuyShares");
			this.Property(t => t.FIActualBuyShares).HasColumnName("FIActualBuyShares");
			this.Property(t => t.InitiatorHoldFloatShares).HasColumnName("InitiatorHoldFloatShares");
			this.Property(t => t.InitiatorHoldTerm).HasColumnName("InitiatorHoldTerm");
			this.Property(t => t.MiniInitiatorHoldingRatio).HasColumnName("MiniInitiatorHoldingRatio");
			this.Property(t => t.SharesAfterAdded).HasColumnName("SharesAfterAdded");
			this.Property(t => t.DurationExtended).HasColumnName("DurationExtended");
			this.Property(t => t.DurationAfterAdded).HasColumnName("DurationAfterAdded");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.ExpireDate).HasColumnName("ExpireDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

