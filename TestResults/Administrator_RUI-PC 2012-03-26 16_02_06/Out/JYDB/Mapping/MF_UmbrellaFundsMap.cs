using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_UmbrellaFundsMap : EntityTypeConfiguration<MF_UmbrellaFunds>
	{
		public MF_UmbrellaFundsMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.UmbrellaFund)
				.IsRequired()
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("MF_UmbrellaFunds");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.UmbrellaFund).HasColumnName("UmbrellaFund");
			this.Property(t => t.UmbrellaFundCode).HasColumnName("UmbrellaFundCode");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

