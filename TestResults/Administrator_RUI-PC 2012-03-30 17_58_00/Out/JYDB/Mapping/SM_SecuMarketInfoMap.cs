using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class SM_SecuMarketInfoMap : EntityTypeConfiguration<SM_SecuMarketInfo>
	{
		public SM_SecuMarketInfoMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("SM_SecuMarketInfo");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.TotalMarketCapitalization).HasColumnName("TotalMarketCapitalization");
			this.Property(t => t.NegotiableCapitalization).HasColumnName("NegotiableCapitalization");
			this.Property(t => t.TotalCapital).HasColumnName("TotalCapital");
			this.Property(t => t.TotalRaisedCapital).HasColumnName("TotalRaisedCapital");
			this.Property(t => t.StockTurnover).HasColumnName("StockTurnover");
			this.Property(t => t.TotalInvestors).HasColumnName("TotalInvestors");
			this.Property(t => t.StampDuty).HasColumnName("StampDuty");
			this.Property(t => t.AShareIssueNum).HasColumnName("AShareIssueNum");
			this.Property(t => t.AShareIssueNumIPO).HasColumnName("AShareIssueNumIPO");
			this.Property(t => t.AShareIssueNumRe).HasColumnName("AShareIssueNumRe");
			this.Property(t => t.AShareIssueNumRight).HasColumnName("AShareIssueNumRight");
			this.Property(t => t.CBIssueNum).HasColumnName("CBIssueNum");
			this.Property(t => t.BShareIssueNum).HasColumnName("BShareIssueNum");
			this.Property(t => t.BShareIssueNumIPO).HasColumnName("BShareIssueNumIPO");
			this.Property(t => t.BShareIssueNumRe).HasColumnName("BShareIssueNumRe");
			this.Property(t => t.HShareIssueNum).HasColumnName("HShareIssueNum");
			this.Property(t => t.HShareIssueNumIPO).HasColumnName("HShareIssueNumIPO");
			this.Property(t => t.HShareIssueNumRe).HasColumnName("HShareIssueNumRe");
			this.Property(t => t.AShareRaisedCapital).HasColumnName("AShareRaisedCapital");
			this.Property(t => t.AShareRaisedCapitalIPO).HasColumnName("AShareRaisedCapitalIPO");
			this.Property(t => t.AShareRaisedCapitalRe).HasColumnName("AShareRaisedCapitalRe");
			this.Property(t => t.AShareRaisedCapitalRight).HasColumnName("AShareRaisedCapitalRight");
			this.Property(t => t.CBRaisedCapital).HasColumnName("CBRaisedCapital");
			this.Property(t => t.BShareRaisedCapital).HasColumnName("BShareRaisedCapital");
			this.Property(t => t.BShareRaisedCapitalIPO).HasColumnName("BShareRaisedCapitalIPO");
			this.Property(t => t.BShareRaisedCapitalRe).HasColumnName("BShareRaisedCapitalRe");
			this.Property(t => t.HShareRaisedCapital).HasColumnName("HShareRaisedCapital");
			this.Property(t => t.HShareRaisedCapitalIPO).HasColumnName("HShareRaisedCapitalIPO");
			this.Property(t => t.HShareRaisedCapitalRe).HasColumnName("HShareRaisedCapitalRe");
			this.Property(t => t.AShareIssueVolume).HasColumnName("AShareIssueVolume");
			this.Property(t => t.AShareIssueVolumeIPO).HasColumnName("AShareIssueVolumeIPO");
			this.Property(t => t.AShareIssueVolumeRe).HasColumnName("AShareIssueVolumeRe");
			this.Property(t => t.AShareIssueVolumeRight).HasColumnName("AShareIssueVolumeRight");
			this.Property(t => t.CBIssueVolume).HasColumnName("CBIssueVolume");
			this.Property(t => t.BShareIssueVolume).HasColumnName("BShareIssueVolume");
			this.Property(t => t.BShareIssueVolumeIPO).HasColumnName("BShareIssueVolumeIPO");
			this.Property(t => t.BShareIssueVolumeRe).HasColumnName("BShareIssueVolumeRe");
			this.Property(t => t.HShareIssueVolume).HasColumnName("HShareIssueVolume");
			this.Property(t => t.HShareIssueVolumeIPO).HasColumnName("HShareIssueVolumeIPO");
			this.Property(t => t.HShareIssueVolumeRe).HasColumnName("HShareIssueVolumeRe");
			this.Property(t => t.AorBShareListedNum).HasColumnName("AorBShareListedNum");
			this.Property(t => t.Bshares).HasColumnName("Bshares");
			this.Property(t => t.Hshares).HasColumnName("Hshares");
			this.Property(t => t.ASharesOnly).HasColumnName("ASharesOnly");
			this.Property(t => t.BSharesOnly).HasColumnName("BSharesOnly");
			this.Property(t => t.HSharesOnly).HasColumnName("HSharesOnly");
			this.Property(t => t.AandBShares).HasColumnName("AandBShares");
			this.Property(t => t.AandHShares).HasColumnName("AandHShares");
			this.Property(t => t.HSharesTotalNum).HasColumnName("HSharesTotalNum");
			this.Property(t => t.HShareOnlyNum).HasColumnName("HShareOnlyNum");
			this.Property(t => t.AandHSharesNum).HasColumnName("AandHSharesNum");
			this.Property(t => t.HShareUSAOnly).HasColumnName("HShareUSAOnly");
			this.Property(t => t.HShareLondonOnly).HasColumnName("HShareLondonOnly");
			this.Property(t => t.HShareSingaporeOnly).HasColumnName("HShareSingaporeOnly");
			this.Property(t => t.HShareHKOnly).HasColumnName("HShareHKOnly");
			this.Property(t => t.HShareHKandUSA).HasColumnName("HShareHKandUSA");
			this.Property(t => t.HShareHKandLondon).HasColumnName("HShareHKandLondon");
			this.Property(t => t.HShareHKandSingapore).HasColumnName("HShareHKandSingapore");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

