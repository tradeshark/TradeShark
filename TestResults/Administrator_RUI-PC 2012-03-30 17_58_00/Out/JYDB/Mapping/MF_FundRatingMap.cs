using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FundRatingMap : EntityTypeConfiguration<MF_FundRating>
	{
		public MF_FundRatingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("MF_FundRating");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.OrganizationCode).HasColumnName("OrganizationCode");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.FundInnerCode).HasColumnName("FundInnerCode");
			this.Property(t => t.InvestmentStyle).HasColumnName("InvestmentStyle");
			this.Property(t => t.UnitNV).HasColumnName("UnitNV");
			this.Property(t => t.WeeklyYield).HasColumnName("WeeklyYield");
			this.Property(t => t.MonthlyYield).HasColumnName("MonthlyYield");
			this.Property(t => t.YieldFor3Month).HasColumnName("YieldFor3Month");
			this.Property(t => t.YieldFor6Month).HasColumnName("YieldFor6Month");
			this.Property(t => t.YieldFor1year).HasColumnName("YieldFor1year");
			this.Property(t => t.YieldFor2year).HasColumnName("YieldFor2year");
			this.Property(t => t.YieldFor3year).HasColumnName("YieldFor3year");
			this.Property(t => t.YieldFor5year).HasColumnName("YieldFor5year");
			this.Property(t => t.YieldFor10year).HasColumnName("YieldFor10year");
			this.Property(t => t.YieldForThisyear).HasColumnName("YieldForThisyear");
			this.Property(t => t.YieldSinceFounded).HasColumnName("YieldSinceFounded");
			this.Property(t => t.RatingPeriod).HasColumnName("RatingPeriod");
			this.Property(t => t.EndDateOfRatingPeriod).HasColumnName("EndDateOfRatingPeriod");
			this.Property(t => t.Stdev).HasColumnName("Stdev");
			this.Property(t => t.StdevEvaluation).HasColumnName("StdevEvaluation");
			this.Property(t => t.RiskFactor).HasColumnName("RiskFactor");
			this.Property(t => t.RiskEvaluation).HasColumnName("RiskEvaluation");
			this.Property(t => t.SharpRatio).HasColumnName("SharpRatio");
			this.Property(t => t.SharpRatioEvaluation).HasColumnName("SharpRatioEvaluation");
			this.Property(t => t.RatingIndicator).HasColumnName("RatingIndicator");
			this.Property(t => t.StarRank).HasColumnName("StarRank");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

