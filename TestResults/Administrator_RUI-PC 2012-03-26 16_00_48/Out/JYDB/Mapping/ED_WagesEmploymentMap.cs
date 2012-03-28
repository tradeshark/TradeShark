using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_WagesEmploymentMap : EntityTypeConfiguration<ED_WagesEmployment>
	{
		public ED_WagesEmploymentMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_WagesEmployment");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.TotalEmployee).HasColumnName("TotalEmployee");
			this.Property(t => t.SOEEmployee).HasColumnName("SOEEmployee");
			this.Property(t => t.TCEEmployee).HasColumnName("TCEEmployee");
			this.Property(t => t.OtherEmployee).HasColumnName("OtherEmployee");
			this.Property(t => t.TotalLarborPartcipants).HasColumnName("TotalLarborPartcipants");
			this.Property(t => t.SOELarborPartcipants).HasColumnName("SOELarborPartcipants");
			this.Property(t => t.TCELarborPartcipants).HasColumnName("TCELarborPartcipants");
			this.Property(t => t.OtherLarborPartcipants).HasColumnName("OtherLarborPartcipants");
			this.Property(t => t.TotalEmployeedWages).HasColumnName("TotalEmployeedWages");
			this.Property(t => t.TotalSOEEmployeeWages).HasColumnName("TotalSOEEmployeeWages");
			this.Property(t => t.TotalTCEEmployeeWages).HasColumnName("TotalTCEEmployeeWages");
			this.Property(t => t.TotalOtherEmployeeWages).HasColumnName("TotalOtherEmployeeWages");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

