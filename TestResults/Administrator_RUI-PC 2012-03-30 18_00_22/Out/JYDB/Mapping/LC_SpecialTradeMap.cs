using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SpecialTradeMap : EntityTypeConfiguration<LC_SpecialTrade>
	{
		public LC_SpecialTradeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InfoPublDate, t.SpecialTradeType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SecurityAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.SpecialTradeType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SpecialTradeExplain)
				.HasMaxLength(255);
				
			this.Property(t => t.SpecialTradeReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_SpecialTrade");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.SecurityAbbr).HasColumnName("SecurityAbbr");
			this.Property(t => t.SpecialTradeType).HasColumnName("SpecialTradeType");
			this.Property(t => t.SpecialTradeTime).HasColumnName("SpecialTradeTime");
			this.Property(t => t.SpecialTradeExplain).HasColumnName("SpecialTradeExplain");
			this.Property(t => t.SpecialTradeReason).HasColumnName("SpecialTradeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

