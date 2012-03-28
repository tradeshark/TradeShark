using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_RMBInterestRateMap : EntityTypeConfiguration<ED_RMBInterestRate>
	{
		public ED_RMBInterestRateMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			this.Property(t => t.ODOptionalTimeOrDemand)
				.HasMaxLength(100);
				
			this.Property(t => t.Discount)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_RMBInterestRate");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.AdjustDate).HasColumnName("AdjustDate");
			this.Property(t => t.DemandDeposits).HasColumnName("DemandDeposits");
			this.Property(t => t.TimeDeposit3M).HasColumnName("TimeDeposit3M");
			this.Property(t => t.TimeDeposit6M).HasColumnName("TimeDeposit6M");
			this.Property(t => t.TimeDeposit1Y).HasColumnName("TimeDeposit1Y");
			this.Property(t => t.TimeDeposit2Y).HasColumnName("TimeDeposit2Y");
			this.Property(t => t.TimeDeposit3Y).HasColumnName("TimeDeposit3Y");
			this.Property(t => t.TimeDeposit5Y).HasColumnName("TimeDeposit5Y");
			this.Property(t => t.OD1Y).HasColumnName("OD1Y");
			this.Property(t => t.OD3Y).HasColumnName("OD3Y");
			this.Property(t => t.OD5Y).HasColumnName("OD5Y");
			this.Property(t => t.ODOptionalTimeOrDemand).HasColumnName("ODOptionalTimeOrDemand");
			this.Property(t => t.ODContractualDeposits).HasColumnName("ODContractualDeposits");
			this.Property(t => t.NoticeDeposits1D).HasColumnName("NoticeDeposits1D");
			this.Property(t => t.NoticeDeposits7D).HasColumnName("NoticeDeposits7D");
			this.Property(t => t.STBelow6Months).HasColumnName("STBelow6Months");
			this.Property(t => t.ST6to12Months).HasColumnName("ST6to12Months");
			this.Property(t => t.MLT1to3years).HasColumnName("MLT1to3years");
			this.Property(t => t.MLT3to5years).HasColumnName("MLT3to5years");
			this.Property(t => t.MLT5Plusyears).HasColumnName("MLT5Plusyears");
			this.Property(t => t.Discount).HasColumnName("Discount");
			this.Property(t => t.IHAF5YBelow).HasColumnName("IHAF5YBelow");
			this.Property(t => t.IHAF5YAbove).HasColumnName("IHAF5YAbove");
			this.Property(t => t.CBankIHAF6Mbelow).HasColumnName("CBankIHAF6Mbelow");
			this.Property(t => t.CBankIHAF6Mto1Y).HasColumnName("CBankIHAF6Mto1Y");
			this.Property(t => t.CBankIHAF1to3Y).HasColumnName("CBankIHAF1to3Y");
			this.Property(t => t.CBankIHAF3to5Y).HasColumnName("CBankIHAF3to5Y");
			this.Property(t => t.CBankIHAF5YAbove).HasColumnName("CBankIHAF5YAbove");
			this.Property(t => t.ReserveDeposit).HasColumnName("ReserveDeposit");
			this.Property(t => t.ExcessReserveDeposit).HasColumnName("ExcessReserveDeposit");
			this.Property(t => t.Reloan20D).HasColumnName("Reloan20D");
			this.Property(t => t.Reloan3M).HasColumnName("Reloan3M");
			this.Property(t => t.Reloan6M).HasColumnName("Reloan6M");
			this.Property(t => t.Reloan1Y).HasColumnName("Reloan1Y");
			this.Property(t => t.ReDiscount).HasColumnName("ReDiscount");
			this.Property(t => t.LoanToWelfareEnterprise).HasColumnName("LoanToWelfareEnterprise");
			this.Property(t => t.LoanToDevelopingAreas).HasColumnName("LoanToDevelopingAreas");
			this.Property(t => t.LoanToPoorCounty).HasColumnName("LoanToPoorCounty");
			this.Property(t => t.LoanToNationTrade).HasColumnName("LoanToNationTrade");
			this.Property(t => t.DiscountLoanToPA).HasColumnName("DiscountLoanToPA");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

