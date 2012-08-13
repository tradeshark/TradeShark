using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SHPromiseMap : EntityTypeConfiguration<LC_SHPromise>
	{
		public LC_SHPromiseMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SHName)
				.HasMaxLength(200);
				
			this.Property(t => t.OtherConsideration)
				.HasMaxLength(500);
				
			this.Property(t => t.PromisingRestrictedStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.LowestHoldingStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.StepSaleStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.ListingPriceCondition)
				.HasMaxLength(200);
				
			this.Property(t => t.ListingPriceTerm)
				.HasMaxLength(200);
				
			this.Property(t => t.PromiseStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.AddingHoldingTime)
				.HasMaxLength(200);
				
			this.Property(t => t.AddingHoldingPriceStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.AddingHoldingSize)
				.HasMaxLength(200);
				
			this.Property(t => t.AddingHoldingStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.SaleRightTime)
				.HasMaxLength(200);
				
			this.Property(t => t.SaleExerciseTerms)
				.HasMaxLength(200);
				
			this.Property(t => t.SaleRightSize)
				.HasMaxLength(200);
				
			this.Property(t => t.SaleRightStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.AddingGrantingTime)
				.HasMaxLength(200);
				
			this.Property(t => t.AddingGrantingTrigger)
				.HasMaxLength(1000);
				
			this.Property(t => t.AddingGrantingSize)
				.HasMaxLength(200);
				
			this.Property(t => t.AddingGrantingStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.MarginPayingTime)
				.HasMaxLength(200);
				
			this.Property(t => t.MarginPayingCondition)
				.HasMaxLength(200);
				
			this.Property(t => t.MarginPayingAmount)
				.HasMaxLength(200);
				
			this.Property(t => t.MarginPayingStatement)
				.HasMaxLength(1000);
				
			this.Property(t => t.StimulantTime)
				.HasMaxLength(200);
				
			this.Property(t => t.StimulantCondition)
				.HasMaxLength(200);
				
			this.Property(t => t.ShareStimulusStatement)
				.HasMaxLength(500);
				
			this.Property(t => t.DividendPromise)
				.HasMaxLength(1000);
				
			this.Property(t => t.DefaultPromise)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_SHPromise");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.PromiseSubject).HasColumnName("PromiseSubject");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.IfEffected).HasColumnName("IfEffected");
			this.Property(t => t.SHSN).HasColumnName("SHSN");
			this.Property(t => t.SHName).HasColumnName("SHName");
			this.Property(t => t.CompanyNumber).HasColumnName("CompanyNumber");
			this.Property(t => t.PromiseType).HasColumnName("PromiseType");
			this.Property(t => t.ShareConsideration).HasColumnName("ShareConsideration");
			this.Property(t => t.CashConsideration).HasColumnName("CashConsideration");
			this.Property(t => t.WarrantConsideration).HasColumnName("WarrantConsideration");
			this.Property(t => t.ShareCompressed).HasColumnName("ShareCompressed");
			this.Property(t => t.ShareConsiderationTranPaid).HasColumnName("ShareConsiderationTranPaid");
			this.Property(t => t.CashConsiderationTranPaid).HasColumnName("CashConsiderationTranPaid");
			this.Property(t => t.WarrantConsiderationTranPaid).HasColumnName("WarrantConsiderationTranPaid");
			this.Property(t => t.OtherConsideration).HasColumnName("OtherConsideration");
			this.Property(t => t.HoldingBeforeConsideration).HasColumnName("HoldingBeforeConsideration");
			this.Property(t => t.ATradableShare).HasColumnName("ATradableShare");
			this.Property(t => t.ShareKind).HasColumnName("ShareKind");
			this.Property(t => t.HoldingRatioBConsideration).HasColumnName("HoldingRatioBConsideration");
			this.Property(t => t.PledgedShare).HasColumnName("PledgedShare");
			this.Property(t => t.FrozenShare).HasColumnName("FrozenShare");
			this.Property(t => t.HoldingAfterConsideration).HasColumnName("HoldingAfterConsideration");
			this.Property(t => t.ATShareUnrestricted).HasColumnName("ATShareUnrestricted");
			this.Property(t => t.HoldingRatioAConsideration).HasColumnName("HoldingRatioAConsideration");
			this.Property(t => t.ListingDate).HasColumnName("ListingDate");
			this.Property(t => t.PromisingRestrictedTerm).HasColumnName("PromisingRestrictedTerm");
			this.Property(t => t.PromisingRestrictedStatement).HasColumnName("PromisingRestrictedStatement");
			this.Property(t => t.PromisingHoldingRatio).HasColumnName("PromisingHoldingRatio");
			this.Property(t => t.TermOfHoldingRatio).HasColumnName("TermOfHoldingRatio");
			this.Property(t => t.EndDateOfHoldingRatio).HasColumnName("EndDateOfHoldingRatio");
			this.Property(t => t.LowestHoldingStatement).HasColumnName("LowestHoldingStatement");
			this.Property(t => t.FirstSaleRatio).HasColumnName("FirstSaleRatio");
			this.Property(t => t.FirstSaleTerm).HasColumnName("FirstSaleTerm");
			this.Property(t => t.SecondSaleRatio).HasColumnName("SecondSaleRatio");
			this.Property(t => t.SecondSaleTerm).HasColumnName("SecondSaleTerm");
			this.Property(t => t.StepSaleStatement).HasColumnName("StepSaleStatement");
			this.Property(t => t.RestrictedListingPrice).HasColumnName("RestrictedListingPrice");
			this.Property(t => t.ListingPriceCondition).HasColumnName("ListingPriceCondition");
			this.Property(t => t.ListingPrice).HasColumnName("ListingPrice");
			this.Property(t => t.ListingPriceTerm).HasColumnName("ListingPriceTerm");
			this.Property(t => t.TermOfRLPrice).HasColumnName("TermOfRLPrice");
			this.Property(t => t.PromiseStatement).HasColumnName("PromiseStatement");
			this.Property(t => t.AddingHoldingTime).HasColumnName("AddingHoldingTime");
			this.Property(t => t.AddingHoldingStartDateType).HasColumnName("AddingHoldingStartDateType");
			this.Property(t => t.AddingHoldingTerm).HasColumnName("AddingHoldingTerm");
			this.Property(t => t.AddingHoldingPriceStatement).HasColumnName("AddingHoldingPriceStatement");
			this.Property(t => t.AddingHoldingTriggerPrice).HasColumnName("AddingHoldingTriggerPrice");
			this.Property(t => t.AddingHoldingPrice).HasColumnName("AddingHoldingPrice");
			this.Property(t => t.AddingHoldingSize).HasColumnName("AddingHoldingSize");
			this.Property(t => t.AddingHoldingShareCeiling).HasColumnName("AddingHoldingShareCeiling");
			this.Property(t => t.AddingHoldingRatioCeiling).HasColumnName("AddingHoldingRatioCeiling");
			this.Property(t => t.AddingHoldingFundCeiling).HasColumnName("AddingHoldingFundCeiling");
			this.Property(t => t.AddingHoldingRestrictedTerm).HasColumnName("AddingHoldingRestrictedTerm");
			this.Property(t => t.AddingHoldingStatement).HasColumnName("AddingHoldingStatement");
			this.Property(t => t.SaleRightTime).HasColumnName("SaleRightTime");
			this.Property(t => t.SaleRightStartDateType).HasColumnName("SaleRightStartDateType");
			this.Property(t => t.SaleRightExerciseTerm).HasColumnName("SaleRightExerciseTerm");
			this.Property(t => t.SaleExerciseTerms).HasColumnName("SaleExerciseTerms");
			this.Property(t => t.SaleRightTriggeringPrice).HasColumnName("SaleRightTriggeringPrice");
			this.Property(t => t.SaleRightPrice).HasColumnName("SaleRightPrice");
			this.Property(t => t.SaleRightSize).HasColumnName("SaleRightSize");
			this.Property(t => t.SaleRightShareRatio).HasColumnName("SaleRightShareRatio");
			this.Property(t => t.SaleExercisePrice).HasColumnName("SaleExercisePrice");
			this.Property(t => t.SaleRightStatement).HasColumnName("SaleRightStatement");
			this.Property(t => t.AddingGrantingTime).HasColumnName("AddingGrantingTime");
			this.Property(t => t.AddingGrantingStartDateType).HasColumnName("AddingGrantingStartDateType");
			this.Property(t => t.AddingGrantingTerm).HasColumnName("AddingGrantingTerm");
			this.Property(t => t.AddingGrantingTrigger).HasColumnName("AddingGrantingTrigger");
			this.Property(t => t.AddingGrantingSize).HasColumnName("AddingGrantingSize");
			this.Property(t => t.AddingGrantingRate).HasColumnName("AddingGrantingRate");
			this.Property(t => t.AddingGrantingShares).HasColumnName("AddingGrantingShares");
			this.Property(t => t.AddingGrantingRatio).HasColumnName("AddingGrantingRatio");
			this.Property(t => t.AddingGrantingTimes).HasColumnName("AddingGrantingTimes");
			this.Property(t => t.AddingGrantingStatement).HasColumnName("AddingGrantingStatement");
			this.Property(t => t.MarginPayingTime).HasColumnName("MarginPayingTime");
			this.Property(t => t.MarginPayingStartDateType).HasColumnName("MarginPayingStartDateType");
			this.Property(t => t.MarginPayingTerm).HasColumnName("MarginPayingTerm");
			this.Property(t => t.MarginPayingCondition).HasColumnName("MarginPayingCondition");
			this.Property(t => t.MarginPayingTrigger).HasColumnName("MarginPayingTrigger");
			this.Property(t => t.MarginPayingPrice).HasColumnName("MarginPayingPrice");
			this.Property(t => t.MarginPayingAmount).HasColumnName("MarginPayingAmount");
			this.Property(t => t.MarginPayingShares).HasColumnName("MarginPayingShares");
			this.Property(t => t.MarginPayingRatio).HasColumnName("MarginPayingRatio");
			this.Property(t => t.MarginPayingStatement).HasColumnName("MarginPayingStatement");
			this.Property(t => t.StimulantTime).HasColumnName("StimulantTime");
			this.Property(t => t.StimulantCondition).HasColumnName("StimulantCondition");
			this.Property(t => t.StimulantShareBConsideration).HasColumnName("StimulantShareBConsideration");
			this.Property(t => t.StimulantShareAConsideration).HasColumnName("StimulantShareAConsideration");
			this.Property(t => t.SubscribingPrice).HasColumnName("SubscribingPrice");
			this.Property(t => t.SubscribingPriceCondition).HasColumnName("SubscribingPriceCondition");
			this.Property(t => t.ExercisePrice).HasColumnName("ExercisePrice");
			this.Property(t => t.ShareStimulusStatement).HasColumnName("ShareStimulusStatement");
			this.Property(t => t.DividendPromise).HasColumnName("DividendPromise");
			this.Property(t => t.DefaultPromise).HasColumnName("DefaultPromise");
			this.Property(t => t.OtherPromise).HasColumnName("OtherPromise");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DeadlineOfRLPrice).HasColumnName("DeadlineOfRLPrice");
			this.Property(t => t.SharesInvolved).HasColumnName("SharesInvolved");
			this.Property(t => t.RestrictedState).HasColumnName("RestrictedState");
			this.Property(t => t.ProlongedLockupPeriod).HasColumnName("ProlongedLockupPeriod");
			this.Property(t => t.DeadlineLockupDate).HasColumnName("DeadlineLockupDate");
			this.Property(t => t.FirstSaleHoldingRatio).HasColumnName("FirstSaleHoldingRatio");
			this.Property(t => t.SecondSaleHoldingRatio).HasColumnName("SecondSaleHoldingRatio");
		}
	}
}

