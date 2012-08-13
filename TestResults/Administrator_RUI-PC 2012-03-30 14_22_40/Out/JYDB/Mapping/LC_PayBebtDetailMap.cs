using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PayBebtDetailMap : EntityTypeConfiguration<LC_PayBebtDetail>
	{
		public LC_PayBebtDetailMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.Debtor)
				.HasMaxLength(200);
				
			this.Property(t => t.RelationshipStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.PayBebtWayStatement)
				.HasMaxLength(200);
				
			this.Property(t => t.PayBebtDateStatement)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_PayBebtDetail");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.EventType).HasColumnName("EventType");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.Debtor).HasColumnName("Debtor");
			this.Property(t => t.RelationshipStatement).HasColumnName("RelationshipStatement");
			this.Property(t => t.Relationship).HasColumnName("Relationship");
			this.Property(t => t.PayBebtWayStatement).HasColumnName("PayBebtWayStatement");
			this.Property(t => t.PayBebtSum).HasColumnName("PayBebtSum");
			this.Property(t => t.PayBebtDateStatement).HasColumnName("PayBebtDateStatement");
			this.Property(t => t.PayBebtEndDate).HasColumnName("PayBebtEndDate");
			this.Property(t => t.AnnouncementType).HasColumnName("AnnouncementType");
			this.Property(t => t.PayBebtDescribe).HasColumnName("PayBebtDescribe");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

