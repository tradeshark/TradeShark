using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_LargeSHSubscriptionMap : EntityTypeConfiguration<LC_LargeSHSubscription>
	{
		public LC_LargeSHSubscriptionMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InitialInfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SHName)
				.HasMaxLength(120);
				
			// Table & Column Mappings
			this.ToTable("LC_LargeSHSubscription");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.SHSN).HasColumnName("SHSN");
			this.Property(t => t.SHName).HasColumnName("SHName");
			this.Property(t => t.SubscriptionWay).HasColumnName("SubscriptionWay");
			this.Property(t => t.OughtShares).HasColumnName("OughtShares");
			this.Property(t => t.ActualShares).HasColumnName("ActualShares");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

