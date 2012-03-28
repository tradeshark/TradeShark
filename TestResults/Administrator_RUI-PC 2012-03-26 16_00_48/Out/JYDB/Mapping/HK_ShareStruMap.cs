using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_ShareStruMap : EntityTypeConfiguration<HK_ShareStru>
	{
		public HK_ShareStruMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.ChangeReason)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_ShareStru");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ParValueUnitComShare).HasColumnName("ParValueUnitComShare");
			this.Property(t => t.ParValueComShare).HasColumnName("ParValueComShare");
			this.Property(t => t.ParValueUnitPreShare).HasColumnName("ParValueUnitPreShare");
			this.Property(t => t.ParValuePreShare).HasColumnName("ParValuePreShare");
			this.Property(t => t.AuthorizedCapitalComShare).HasColumnName("AuthorizedCapitalComShare");
			this.Property(t => t.AuthorizedSharesComShare).HasColumnName("AuthorizedSharesComShare");
			this.Property(t => t.PaidUpCapitalComShare).HasColumnName("PaidUpCapitalComShare");
			this.Property(t => t.PaidUpSharesComShare).HasColumnName("PaidUpSharesComShare");
			this.Property(t => t.ListedShares).HasColumnName("ListedShares");
			this.Property(t => t.UnlistedShares).HasColumnName("UnlistedShares");
			this.Property(t => t.NotHKShares).HasColumnName("NotHKShares");
			this.Property(t => t.AuthorizedCapitalPreShare).HasColumnName("AuthorizedCapitalPreShare");
			this.Property(t => t.AuthorizedSharesPreShare).HasColumnName("AuthorizedSharesPreShare");
			this.Property(t => t.PaidUpCapitalPreShare).HasColumnName("PaidUpCapitalPreShare");
			this.Property(t => t.PaidUpSharesPreShare).HasColumnName("PaidUpSharesPreShare");
			this.Property(t => t.AuthorizedCapitalTotal).HasColumnName("AuthorizedCapitalTotal");
			this.Property(t => t.AuthorizedSharesTotal).HasColumnName("AuthorizedSharesTotal");
			this.Property(t => t.PaidUpCapitalTotal).HasColumnName("PaidUpCapitalTotal");
			this.Property(t => t.PaidUpSharesTotal).HasColumnName("PaidUpSharesTotal");
			this.Property(t => t.PaidUpSharesChgComShare).HasColumnName("PaidUpSharesChgComShare");
			this.Property(t => t.PaidUpSharesChgPreShare).HasColumnName("PaidUpSharesChgPreShare");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

