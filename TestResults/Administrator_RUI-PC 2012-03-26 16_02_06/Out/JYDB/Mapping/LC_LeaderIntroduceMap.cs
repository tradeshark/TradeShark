using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_LeaderIntroduceMap : EntityTypeConfiguration<LC_LeaderIntroduce>
	{
		public LC_LeaderIntroduceMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.LeaderName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.LeaderName)
				.IsRequired()
				.HasMaxLength(50);
				
			this.Property(t => t.Statement)
				.HasMaxLength(255);
				
			this.Property(t => t.BirthYMInfo)
				.HasMaxLength(20);
				
			this.Property(t => t.ConcurrentPost)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_LeaderIntroduce");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.LeaderName).HasColumnName("LeaderName");
			this.Property(t => t.Position).HasColumnName("Position");
			this.Property(t => t.LeaderTitle).HasColumnName("LeaderTitle");
			this.Property(t => t.TermNumIn).HasColumnName("TermNumIn");
			this.Property(t => t.LeaderGender).HasColumnName("LeaderGender");
			this.Property(t => t.BirthYM).HasColumnName("BirthYM");
			this.Property(t => t.LeaderDegree).HasColumnName("LeaderDegree");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.IfIn).HasColumnName("IfIn");
			this.Property(t => t.InDate).HasColumnName("InDate");
			this.Property(t => t.OffDate).HasColumnName("OffDate");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.BirthYMInfo).HasColumnName("BirthYMInfo");
			this.Property(t => t.ConcurrentPost).HasColumnName("ConcurrentPost");
		}
	}
}

