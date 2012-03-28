using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_DividendMap : EntityTypeConfiguration<MF_Dividend>
	{
		public MF_DividendMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SchemeModification)
				.HasMaxLength(250);
				
			this.Property(t => t.EventProcedure)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("MF_Dividend");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.UnitProfit).HasColumnName("UnitProfit");
			this.Property(t => t.UnitRetainedProfit).HasColumnName("UnitRetainedProfit");
			this.Property(t => t.IfDistributed).HasColumnName("IfDistributed");
			this.Property(t => t.DividendRatioBeforeTax).HasColumnName("DividendRatioBeforeTax");
			this.Property(t => t.ActualRatioAfterTax).HasColumnName("ActualRatioAfterTax");
			this.Property(t => t.Dividendsum).HasColumnName("Dividendsum");
			this.Property(t => t.ReDate).HasColumnName("ReDate");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.ExecuteDate).HasColumnName("ExecuteDate");
			this.Property(t => t.SchemeModification).HasColumnName("SchemeModification");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.ReinvestDay).HasColumnName("ReinvestDay");
			this.Property(t => t.AccountDay).HasColumnName("AccountDay");
			this.Property(t => t.RedemptionDay).HasColumnName("RedemptionDay");
			this.Property(t => t.UnitProfitYTD).HasColumnName("UnitProfitYTD");
			this.Property(t => t.DividendSumYTD).HasColumnName("DividendSumYTD");
			this.Property(t => t.DividendTimesYTD).HasColumnName("DividendTimesYTD");
			this.Property(t => t.DiviSumSinceInception).HasColumnName("DiviSumSinceInception");
			this.Property(t => t.DiviTimesSinceIncepion).HasColumnName("DiviTimesSinceIncepion");
			this.Property(t => t.EventProcedureCode).HasColumnName("EventProcedureCode");
			this.Property(t => t.EventProcedure).HasColumnName("EventProcedure");
			this.Property(t => t.ExRightDateEX).HasColumnName("ExRightDateEX");
			this.Property(t => t.ExRightDateCurbEX).HasColumnName("ExRightDateCurbEX");
		}
	}
}

