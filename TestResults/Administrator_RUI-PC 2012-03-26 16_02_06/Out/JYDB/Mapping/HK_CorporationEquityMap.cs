using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_CorporationEquityMap : EntityTypeConfiguration<HK_CorporationEquity>
	{
		public HK_CorporationEquityMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.DirectorName)
				.HasMaxLength(200);
				
			this.Property(t => t.CorporationName)
				.HasMaxLength(200);
				
			this.Property(t => t.EquityStatusDesc)
				.HasMaxLength(200);
				
			this.Property(t => t.RelatingEquityStatusDesc)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("HK_CorporationEquity");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DirectorName).HasColumnName("DirectorName");
			this.Property(t => t.CorporationName).HasColumnName("CorporationName");
			this.Property(t => t.EquityType).HasColumnName("EquityType");
			this.Property(t => t.EquityCharacter).HasColumnName("EquityCharacter");
			this.Property(t => t.Unit).HasColumnName("Unit");
			this.Property(t => t.EquityStatus).HasColumnName("EquityStatus");
			this.Property(t => t.EquityStatusDesc).HasColumnName("EquityStatusDesc");
			this.Property(t => t.RelatingEquityStatus).HasColumnName("RelatingEquityStatus");
			this.Property(t => t.RelatingEquityStatusDesc).HasColumnName("RelatingEquityStatusDesc");
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

