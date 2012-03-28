using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_TopTenHolderMap : EntityTypeConfiguration<MF_TopTenHolder>
	{
		public MF_TopTenHolderMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.HolderName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.HolderName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.HolderCode)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("MF_TopTenHolder");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.HolderName).HasColumnName("HolderName");
			this.Property(t => t.HolderCode).HasColumnName("HolderCode");
			this.Property(t => t.HoldingVolume).HasColumnName("HoldingVolume");
			this.Property(t => t.HoldingRatio).HasColumnName("HoldingRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

