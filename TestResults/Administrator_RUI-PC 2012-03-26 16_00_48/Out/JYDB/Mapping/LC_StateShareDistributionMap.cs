using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_StateShareDistributionMap : EntityTypeConfiguration<LC_StateShareDistribution>
	{
		public LC_StateShareDistributionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InitialInfoPublDate, t.ShareType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.ShareType)
				.IsRequired()
				.HasMaxLength(20);
				
			this.Property(t => t.DistributeFrom)
				.HasMaxLength(100);
				
			this.Property(t => t.DistributeTo)
				.HasMaxLength(100);
				
			this.Property(t => t.PublicAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.PricingMode)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_StateShareDistribution");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ShareType).HasColumnName("ShareType");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.PublDate).HasColumnName("PublDate");
			this.Property(t => t.DistributeFrom).HasColumnName("DistributeFrom");
			this.Property(t => t.DistributeTo).HasColumnName("DistributeTo");
			this.Property(t => t.PublicAbbr).HasColumnName("PublicAbbr");
			this.Property(t => t.PublicCode).HasColumnName("PublicCode");
			this.Property(t => t.PricingMode).HasColumnName("PricingMode");
			this.Property(t => t.FaceValue).HasColumnName("FaceValue");
			this.Property(t => t.DistributionPrice).HasColumnName("DistributionPrice");
			this.Property(t => t.PERatio).HasColumnName("PERatio");
			this.Property(t => t.DisrtibuteSum).HasColumnName("DisrtibuteSum");
			this.Property(t => t.Proportion).HasColumnName("Proportion");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
			this.Property(t => t.EXDate).HasColumnName("EXDate");
			this.Property(t => t.PayStartDate).HasColumnName("PayStartDate");
			this.Property(t => t.PayEndDate).HasColumnName("PayEndDate");
			this.Property(t => t.FundPayDate).HasColumnName("FundPayDate");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.PDTradingDate).HasColumnName("PDTradingDate");
			this.Property(t => t.FDTradingDate).HasColumnName("FDTradingDate");
			this.Property(t => t.ActualSum).HasColumnName("ActualSum");
			this.Property(t => t.PActualSum).HasColumnName("PActualSum");
			this.Property(t => t.ManagementSum).HasColumnName("ManagementSum");
			this.Property(t => t.ActualTranDistributeSum).HasColumnName("ActualTranDistributeSum");
			this.Property(t => t.FActualSum).HasColumnName("FActualSum");
			this.Property(t => t.UnderwritedSum).HasColumnName("UnderwritedSum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

