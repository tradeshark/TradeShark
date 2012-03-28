using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_ConHolderMap : EntityTypeConfiguration<BD_ConHolder>
	{
		public BD_ConHolderMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.HolderSN, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.HolderSN)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.HolderName)
				.HasMaxLength(200);
				
			this.Property(t => t.InstitutionName)
				.HasMaxLength(100);
				
			this.Property(t => t.HolderRelationship)
				.HasMaxLength(50);
				
			this.Property(t => t.Remark)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("BD_ConHolder");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.OutstandingVolume).HasColumnName("OutstandingVolume");
			this.Property(t => t.HolderNumber).HasColumnName("HolderNumber");
			this.Property(t => t.HolderSN).HasColumnName("HolderSN");
			this.Property(t => t.HolderName).HasColumnName("HolderName");
			this.Property(t => t.HolderNature).HasColumnName("HolderNature");
			this.Property(t => t.InnerCodeFund).HasColumnName("InnerCodeFund");
			this.Property(t => t.SecuCoBelongedCode).HasColumnName("SecuCoBelongedCode");
			this.Property(t => t.InstitutionName).HasColumnName("InstitutionName");
			this.Property(t => t.HoldVolume).HasColumnName("HoldVolume");
			this.Property(t => t.HoldRatio).HasColumnName("HoldRatio");
			this.Property(t => t.HolderRelationship).HasColumnName("HolderRelationship");
			this.Property(t => t.Remark).HasColumnName("Remark");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

