using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ShareMergerReformMap : EntityTypeConfiguration<LC_ShareMergerReform>
	{
		public LC_ShareMergerReformMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.PrimaryIntention)
				.HasMaxLength(500);
				
			this.Property(t => t.ContactTel)
				.HasMaxLength(50);
				
			this.Property(t => t.Fax)
				.HasMaxLength(50);
				
			this.Property(t => t.Email)
				.HasMaxLength(50);
				
			this.Property(t => t.ContactMan)
				.HasMaxLength(50);
				
			this.Property(t => t.Sponsor)
				.HasMaxLength(200);
				
			this.Property(t => t.SMAddress)
				.HasMaxLength(100);
				
			this.Property(t => t.VoterCollector)
				.HasMaxLength(100);
				
			this.Property(t => t.Authorizingdept)
				.HasMaxLength(100);
				
			this.Property(t => t.SPStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.Note)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("LC_ShareMergerReform");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.LatestInfoPublDate).HasColumnName("LatestInfoPublDate");
			this.Property(t => t.Process).HasColumnName("Process");
			this.Property(t => t.EventAnnounceDate).HasColumnName("EventAnnounceDate");
			this.Property(t => t.PrimaryIntention).HasColumnName("PrimaryIntention");
			this.Property(t => t.ProgramType).HasColumnName("ProgramType");
			this.Property(t => t.ContactTel).HasColumnName("ContactTel");
			this.Property(t => t.Fax).HasColumnName("Fax");
			this.Property(t => t.Email).HasColumnName("Email");
			this.Property(t => t.ContactMan).HasColumnName("ContactMan");
			this.Property(t => t.Sponsor).HasColumnName("Sponsor");
			this.Property(t => t.CompanyNumber).HasColumnName("CompanyNumber");
			this.Property(t => t.SponsorHolding).HasColumnName("SponsorHolding");
			this.Property(t => t.DMDate).HasColumnName("DMDate");
			this.Property(t => t.DMDAnnounceDate).HasColumnName("DMDAnnounceDate");
			this.Property(t => t.OnlineVotingStartDate).HasColumnName("OnlineVotingStartDate");
			this.Property(t => t.OnlineVotingEndDate).HasColumnName("OnlineVotingEndDate");
			this.Property(t => t.SMRecordDate).HasColumnName("SMRecordDate");
			this.Property(t => t.SMDate).HasColumnName("SMDate");
			this.Property(t => t.SMAddress).HasColumnName("SMAddress");
			this.Property(t => t.VoterCollector).HasColumnName("VoterCollector");
			this.Property(t => t.IDCollectStartDate).HasColumnName("IDCollectStartDate");
			this.Property(t => t.IDCollectEndDate).HasColumnName("IDCollectEndDate");
			this.Property(t => t.Authorizingdept).HasColumnName("Authorizingdept");
			this.Property(t => t.IfAuthorized).HasColumnName("IfAuthorized");
			this.Property(t => t.IfFCLPShareAuthorized).HasColumnName("IfFCLPShareAuthorized");
			this.Property(t => t.AuthorizedDate).HasColumnName("AuthorizedDate");
			this.Property(t => t.SMDAnnounceDate).HasColumnName("SMDAnnounceDate");
			this.Property(t => t.IfPassed).HasColumnName("IfPassed");
			this.Property(t => t.ImplementionAnnouceDate).HasColumnName("ImplementionAnnouceDate");
			this.Property(t => t.ImplementionRecordDate).HasColumnName("ImplementionRecordDate");
			this.Property(t => t.SuspendDate).HasColumnName("SuspendDate");
			this.Property(t => t.RecoverTradinDate).HasColumnName("RecoverTradinDate");
			this.Property(t => t.SConsiderationPayDate).HasColumnName("SConsiderationPayDate");
			this.Property(t => t.SConsiderationListDate).HasColumnName("SConsiderationListDate");
			this.Property(t => t.CConsiderationPayDate).HasColumnName("CConsiderationPayDate");
			this.Property(t => t.WarrantIssueDate).HasColumnName("WarrantIssueDate");
			this.Property(t => t.BaseShareCapital).HasColumnName("BaseShareCapital");
			this.Property(t => t.NTShareBR).HasColumnName("NTShareBR");
			this.Property(t => t.NTTermEShare).HasColumnName("NTTermEShare");
			this.Property(t => t.NTEShare).HasColumnName("NTEShare");
			this.Property(t => t.FCLPShareBR).HasColumnName("FCLPShareBR");
			this.Property(t => t.TShareBR).HasColumnName("TShareBR");
			this.Property(t => t.TAShareBR).HasColumnName("TAShareBR");
			this.Property(t => t.BShareBR).HasColumnName("BShareBR");
			this.Property(t => t.HShareBR).HasColumnName("HShareBR");
			this.Property(t => t.OTShareBR).HasColumnName("OTShareBR");
			this.Property(t => t.TotalShareAR).HasColumnName("TotalShareAR");
			this.Property(t => t.RestrainedTShare).HasColumnName("RestrainedTShare");
			this.Property(t => t.RTTermEShare).HasColumnName("RTTermEShare");
			this.Property(t => t.RTEShare).HasColumnName("RTEShare");
			this.Property(t => t.RTFCLPShare).HasColumnName("RTFCLPShare");
			this.Property(t => t.UnstintedTShare).HasColumnName("UnstintedTShare");
			this.Property(t => t.TAShareAR).HasColumnName("TAShareAR");
			this.Property(t => t.BShareAR).HasColumnName("BShareAR");
			this.Property(t => t.HShareAR).HasColumnName("HShareAR");
			this.Property(t => t.OTShareAR).HasColumnName("OTShareAR");
			this.Property(t => t.TotalSharePaid).HasColumnName("TotalSharePaid");
			this.Property(t => t.TotalCashPaid).HasColumnName("TotalCashPaid");
			this.Property(t => t.TotalWarrant).HasColumnName("TotalWarrant");
			this.Property(t => t.SConsideration).HasColumnName("SConsideration");
			this.Property(t => t.CConsideration).HasColumnName("CConsideration");
			this.Property(t => t.Wconsideration).HasColumnName("Wconsideration");
			this.Property(t => t.ShareCompressed).HasColumnName("ShareCompressed");
			this.Property(t => t.SubsidiaryProgram).HasColumnName("SubsidiaryProgram");
			this.Property(t => t.SPStatement).HasColumnName("SPStatement");
			this.Property(t => t.Note).HasColumnName("Note");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ProgramPrePublDate).HasColumnName("ProgramPrePublDate");
			this.Property(t => t.AdjustmentType).HasColumnName("AdjustmentType");
		}
	}
}

