using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_LeaderPositionMap : EntityTypeConfiguration<HK_LeaderPosition>
	{
		public HK_LeaderPositionMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.LeaderName)
				.HasMaxLength(100);
				
			this.Property(t => t.PositionName)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(500);
				
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_LeaderPosition");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.LeaderID).HasColumnName("LeaderID");
			this.Property(t => t.LeaderName).HasColumnName("LeaderName");
			this.Property(t => t.PositionName).HasColumnName("PositionName");
			this.Property(t => t.Position).HasColumnName("Position");
			this.Property(t => t.InDate).HasColumnName("InDate");
			this.Property(t => t.OffDate).HasColumnName("OffDate");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.IfIn).HasColumnName("IfIn");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.PositionType).HasColumnName("PositionType");
		}
	}
}

