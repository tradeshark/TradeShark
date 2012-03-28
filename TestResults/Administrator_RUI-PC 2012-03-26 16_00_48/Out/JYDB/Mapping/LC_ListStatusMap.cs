using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ListStatusMap : EntityTypeConfiguration<LC_ListStatus>
	{
		public LC_ListStatusMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Statement)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_ListStatus");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.LargeApplyingMax).HasColumnName("LargeApplyingMax");
		}
	}
}

