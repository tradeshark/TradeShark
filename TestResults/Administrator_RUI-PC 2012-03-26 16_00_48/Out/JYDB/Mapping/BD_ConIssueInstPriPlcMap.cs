using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_ConIssueInstPriPlcMap : EntityTypeConfiguration<BD_ConIssueInstPriPlc>
	{
		public BD_ConIssueInstPriPlcMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InfoPublDate, t.SerialNumber, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Reason)
				.HasMaxLength(50);
				
			this.Property(t => t.SerialNumber)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AcquirerName)
				.HasMaxLength(200);
				
			this.Property(t => t.AcquirerNature)
				.HasMaxLength(100);
				
			this.Property(t => t.InstitutionName)
				.HasMaxLength(200);
				
			this.Property(t => t.PriPlcNature)
				.HasMaxLength(20);
				
			this.Property(t => t.Remark)
				.HasMaxLength(500);
				
			this.Property(t => t.RelativeListedCom)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("BD_ConIssueInstPriPlc");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.TotalPriPlcVolume).HasColumnName("TotalPriPlcVolume");
			this.Property(t => t.Reason).HasColumnName("Reason");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.AcquirerName).HasColumnName("AcquirerName");
			this.Property(t => t.AcquirerNature).HasColumnName("AcquirerNature");
			this.Property(t => t.InstitutionName).HasColumnName("InstitutionName");
			this.Property(t => t.AcquirerSecuCode).HasColumnName("AcquirerSecuCode");
			this.Property(t => t.Volume).HasColumnName("Volume");
			this.Property(t => t.LockedInPeriod).HasColumnName("LockedInPeriod");
			this.Property(t => t.PriPlcNature).HasColumnName("PriPlcNature");
			this.Property(t => t.TradableDate).HasColumnName("TradableDate");
			this.Property(t => t.Remark).HasColumnName("Remark");
			this.Property(t => t.RelativeListedCom).HasColumnName("RelativeListedCom");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

