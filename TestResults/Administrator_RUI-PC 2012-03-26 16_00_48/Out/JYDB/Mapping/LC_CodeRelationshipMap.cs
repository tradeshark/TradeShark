using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_CodeRelationshipMap : EntityTypeConfiguration<LC_CodeRelationship>
	{
		public LC_CodeRelationshipMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("LC_CodeRelationship");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.CodeDefine).HasColumnName("CodeDefine");
			this.Property(t => t.Market).HasColumnName("Market");
			this.Property(t => t.RelatedInnerCode).HasColumnName("RelatedInnerCode");
			this.Property(t => t.RelatedCompanyCode).HasColumnName("RelatedCompanyCode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

