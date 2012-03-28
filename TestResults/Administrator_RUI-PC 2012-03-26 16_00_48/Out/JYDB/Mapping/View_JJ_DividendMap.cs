using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_DividendMap : EntityTypeConfiguration<View_JJ_Dividend>
	{
		public View_JJ_DividendMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SchemeModification)
				.HasMaxLength(250);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_Dividend");
			this.Property(t => t.N_DividendSum).HasColumnName("N_DividendSum");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.UnitProfit).HasColumnName("UnitProfit");
			this.Property(t => t.UnitRetainedProfit).HasColumnName("UnitRetainedProfit");
			this.Property(t => t.IfDistributed).HasColumnName("IfDistributed");
			this.Property(t => t.DividendRatioBeforeTax).HasColumnName("DividendRatioBeforeTax");
			this.Property(t => t.ActualRatioAfterTax).HasColumnName("ActualRatioAfterTax");
			this.Property(t => t.Dividendsum).HasColumnName("Dividendsum");
			this.Property(t => t.ReDate).HasColumnName("ReDate");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.ExecuteDate).HasColumnName("ExecuteDate");
			this.Property(t => t.SchemeModification).HasColumnName("SchemeModification");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

