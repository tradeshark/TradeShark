using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class trcMap : EntityTypeConfiguration<trc>
	{
		public trcMap()
		{
			// Primary Key
			this.HasKey(t => t.RowNumber);

			// Properties
			this.Property(t => t.ApplicationName)
				.HasMaxLength(128);
				
			this.Property(t => t.NTUserName)
				.HasMaxLength(128);
				
			this.Property(t => t.LoginName)
				.HasMaxLength(128);
				
			// Table & Column Mappings
			this.ToTable("trc");
			this.Property(t => t.RowNumber).HasColumnName("RowNumber");
			this.Property(t => t.EventClass).HasColumnName("EventClass");
			this.Property(t => t.TextData).HasColumnName("TextData");
			this.Property(t => t.ApplicationName).HasColumnName("ApplicationName");
			this.Property(t => t.NTUserName).HasColumnName("NTUserName");
			this.Property(t => t.LoginName).HasColumnName("LoginName");
			this.Property(t => t.CPU).HasColumnName("CPU");
			this.Property(t => t.Reads).HasColumnName("Reads");
			this.Property(t => t.Writes).HasColumnName("Writes");
			this.Property(t => t.Duration).HasColumnName("Duration");
			this.Property(t => t.ClientProcessID).HasColumnName("ClientProcessID");
			this.Property(t => t.SPID).HasColumnName("SPID");
			this.Property(t => t.StartTime).HasColumnName("StartTime");
			this.Property(t => t.BinaryData).HasColumnName("BinaryData");
		}
	}
}

