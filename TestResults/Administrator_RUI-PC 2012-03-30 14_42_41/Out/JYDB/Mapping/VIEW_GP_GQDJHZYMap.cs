using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_GP_GQDJHZYMap : EntityTypeConfiguration<VIEW_GP_GQDJHZY>
	{
		public VIEW_GP_GQDJHZYMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.FPSHName, t.XGRQ });

			// Properties
			this.Property(t => t.N_TypeSelect)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.FPSHName)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.ReceiverName)
				.HasMaxLength(100);
				
			this.Property(t => t.FPReason)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("VIEW_GP_GQDJHZY");
			this.Property(t => t.N_TypeSelect).HasColumnName("N_TypeSelect");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.TypeSelect).HasColumnName("TypeSelect");
			this.Property(t => t.FPSHName).HasColumnName("FPSHName");
			this.Property(t => t.ReceiverName).HasColumnName("ReceiverName");
			this.Property(t => t.InvolvedSum).HasColumnName("InvolvedSum");
			this.Property(t => t.PCTOfPledger).HasColumnName("PCTOfPledger");
			this.Property(t => t.PCTOfTotalShares).HasColumnName("PCTOfTotalShares");
			this.Property(t => t.FPReason).HasColumnName("FPReason");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

