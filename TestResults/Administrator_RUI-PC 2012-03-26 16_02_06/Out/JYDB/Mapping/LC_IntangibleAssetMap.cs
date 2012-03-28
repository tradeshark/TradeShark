using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_IntangibleAssetMap : EntityTypeConfiguration<LC_IntangibleAsset>
	{
		public LC_IntangibleAssetMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Name)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_IntangibleAsset");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.SN).HasColumnName("SN");
			this.Property(t => t.Type).HasColumnName("Type");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.Ownership).HasColumnName("Ownership");
			this.Property(t => t.AcquiringOrUsingWays).HasColumnName("AcquiringOrUsingWays");
			this.Property(t => t.Statements).HasColumnName("Statements");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

