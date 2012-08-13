using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_LeaderIntroduceMap : EntityTypeConfiguration<HK_LeaderIntroduce>
	{
		public HK_LeaderIntroduceMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.LeaderName)
				.HasMaxLength(100);
				
			this.Property(t => t.Statement)
				.HasMaxLength(500);
				
			this.Property(t => t.BirthYMInfo)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("HK_LeaderIntroduce");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.LeaderID).HasColumnName("LeaderID");
			this.Property(t => t.LeaderName).HasColumnName("LeaderName");
			this.Property(t => t.LeaderGender).HasColumnName("LeaderGender");
			this.Property(t => t.BirthYM).HasColumnName("BirthYM");
			this.Property(t => t.Age).HasColumnName("Age");
			this.Property(t => t.LeaderDegree).HasColumnName("LeaderDegree");
			this.Property(t => t.LeaderTitle).HasColumnName("LeaderTitle");
			this.Property(t => t.EarliestInDate).HasColumnName("EarliestInDate");
			this.Property(t => t.Background).HasColumnName("Background");
			this.Property(t => t.Statement).HasColumnName("Statement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.BirthYMInfo).HasColumnName("BirthYMInfo");
		}
	}
}

