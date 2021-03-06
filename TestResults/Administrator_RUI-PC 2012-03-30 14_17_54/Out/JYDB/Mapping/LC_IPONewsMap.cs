using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_IPONewsMap : EntityTypeConfiguration<LC_IPONews>
	{
		public LC_IPONewsMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InfoTitle, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.Media)
				.HasMaxLength(200);
				
			this.Property(t => t.Writer)
				.HasMaxLength(50);
				
			this.Property(t => t.Author)
				.HasMaxLength(50);
				
			this.Property(t => t.InfoTitle)
				.IsRequired()
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_IPONews");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.Media).HasColumnName("Media");
			this.Property(t => t.Writer).HasColumnName("Writer");
			this.Property(t => t.Author).HasColumnName("Author");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.InvolvedStock).HasColumnName("InvolvedStock");
			this.Property(t => t.ObjectCode).HasColumnName("ObjectCode");
			this.Property(t => t.AreaCode).HasColumnName("AreaCode");
			this.Property(t => t.MarketCode).HasColumnName("MarketCode");
			this.Property(t => t.ForecastLowestPrice).HasColumnName("ForecastLowestPrice");
			this.Property(t => t.ForecastHighestPrice).HasColumnName("ForecastHighestPrice");
			this.Property(t => t.InfoLevel).HasColumnName("InfoLevel");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
		}
	}
}

