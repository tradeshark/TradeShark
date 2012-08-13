using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_CodeRelationshipMap : EntityTypeConfiguration<MF_CodeRelationship>
	{
		public MF_CodeRelationshipMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("MF_CodeRelationship");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.CodeDefine).HasColumnName("CodeDefine");
			this.Property(t => t.RelatedInnerCode).HasColumnName("RelatedInnerCode");
			this.Property(t => t.RelatedCompanyCode).HasColumnName("RelatedCompanyCode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

