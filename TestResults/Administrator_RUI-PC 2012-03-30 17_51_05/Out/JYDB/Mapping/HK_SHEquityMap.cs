using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_SHEquityMap : EntityTypeConfiguration<HK_SHEquity>
	{
		public HK_SHEquityMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SHName)
				.HasMaxLength(200);
				
			this.Property(t => t.SHStatusDesc)
				.HasMaxLength(200);
				
			this.Property(t => t.RelatingSHStatusDesc)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("HK_SHEquity");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SHName).HasColumnName("SHName");
			this.Property(t => t.SHKind).HasColumnName("SHKind");
			this.Property(t => t.SHNo).HasColumnName("SHNo");
			this.Property(t => t.EquityType).HasColumnName("EquityType");
			this.Property(t => t.EquityCharacter).HasColumnName("EquityCharacter");
			this.Property(t => t.Unit).HasColumnName("Unit");
			this.Property(t => t.SHStatus).HasColumnName("SHStatus");
			this.Property(t => t.SHStatusDesc).HasColumnName("SHStatusDesc");
			this.Property(t => t.RelatingSHStatus).HasColumnName("RelatingSHStatus");
			this.Property(t => t.RelatingSHStatusDesc).HasColumnName("RelatingSHStatusDesc");
			this.Property(t => t.EquityVolume).HasColumnName("EquityVolume");
			this.Property(t => t.RatioInTotalShares).HasColumnName("RatioInTotalShares");
			this.Property(t => t.HoldSum).HasColumnName("HoldSum");
			this.Property(t => t.HSInTotalShares).HasColumnName("HSInTotalShares");
			this.Property(t => t.PersonalEquity).HasColumnName("PersonalEquity");
			this.Property(t => t.FamilyEquity).HasColumnName("FamilyEquity");
			this.Property(t => t.CompanyEquity).HasColumnName("CompanyEquity");
			this.Property(t => t.OtherEquity).HasColumnName("OtherEquity");
			this.Property(t => t.RelatingEquityHoldSum).HasColumnName("RelatingEquityHoldSum");
			this.Property(t => t.REHSInTotalShares).HasColumnName("REHSInTotalShares");
			this.Property(t => t.StockrightEquity).HasColumnName("StockrightEquity");
			this.Property(t => t.WarrantEquity).HasColumnName("WarrantEquity");
			this.Property(t => t.ConvertibleBondEquity).HasColumnName("ConvertibleBondEquity");
			this.Property(t => t.OtherRelatingEquity).HasColumnName("OtherRelatingEquity");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

