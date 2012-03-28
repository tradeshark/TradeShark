using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_LawsAndStatutesMap : EntityTypeConfiguration<ED_LawsAndStatutes>
	{
		public ED_LawsAndStatutesMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InfoPublDate, t.InfoTitle, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.IfInvalidation)
				.IsFixedLength()
				.HasMaxLength(2);
				
			this.Property(t => t.IssuanceOrg)
				.HasMaxLength(100);
				
			this.Property(t => t.ContentType)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoTitle)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.Notes)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("ED_LawsAndStatutes");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ActualizationDate).HasColumnName("ActualizationDate");
			this.Property(t => t.IfInvalidation).HasColumnName("IfInvalidation");
			this.Property(t => t.IssuanceOrg).HasColumnName("IssuanceOrg");
			this.Property(t => t.ContentType).HasColumnName("ContentType");
			this.Property(t => t.InfoTitle).HasColumnName("InfoTitle");
			this.Property(t => t.Content).HasColumnName("Content");
			this.Property(t => t.Notes).HasColumnName("Notes");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.RecordDate).HasColumnName("RecordDate");
		}
	}
}

