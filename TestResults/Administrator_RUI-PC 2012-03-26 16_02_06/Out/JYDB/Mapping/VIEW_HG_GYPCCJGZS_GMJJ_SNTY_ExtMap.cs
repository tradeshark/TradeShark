using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_GYPCCJGZS_GMJJ_SNTY_ExtMap : EntityTypeConfiguration<VIEW_HG_GYPCCJGZS_GMJJ_SNTY_Ext>
	{
		public VIEW_HG_GYPCCJGZS_GMJJ_SNTY_ExtMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_AdjustMark, t.ID, t.EndDate, t.AdjustMark, t.ReportArea, t.XGRQ });

			// Properties
			this.Property(t => t.N_AdjustMark)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndexType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IndexCode)
				.HasMaxLength(50);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.AdjustMark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndexName)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_GYPCCJGZS_GMJJ_SNTY_Ext");
			this.Property(t => t.N_AdjustMark).HasColumnName("N_AdjustMark");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.N_IndexType).HasColumnName("N_IndexType");
			this.Property(t => t.N_IndexCode).HasColumnName("N_IndexCode");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.IndexType).HasColumnName("IndexType");
			this.Property(t => t.IndexName).HasColumnName("IndexName");
			this.Property(t => t.IndexCode).HasColumnName("IndexCode");
			this.Property(t => t.IndexValue).HasColumnName("IndexValue");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.EXPR1).HasColumnName("EXPR1");
			this.Property(t => t.EXPR2).HasColumnName("EXPR2");
			this.Property(t => t.EXPR3).HasColumnName("EXPR3");
			this.Property(t => t.EXPR4).HasColumnName("EXPR4");
			this.Property(t => t.EXPR5).HasColumnName("EXPR5");
			this.Property(t => t.EXPR6).HasColumnName("EXPR6");
			this.Property(t => t.EXPR7).HasColumnName("EXPR7");
			this.Property(t => t.EXPR8).HasColumnName("EXPR8");
			this.Property(t => t.EXPR9).HasColumnName("EXPR9");
			this.Property(t => t.EXPR10).HasColumnName("EXPR10");
			this.Property(t => t.EXPR11).HasColumnName("EXPR11");
			this.Property(t => t.EXPR12).HasColumnName("EXPR12");
			this.Property(t => t.EXPR13).HasColumnName("EXPR13");
			this.Property(t => t.EXPR14).HasColumnName("EXPR14");
			this.Property(t => t.EXPR15).HasColumnName("EXPR15");
			this.Property(t => t.EXPR16).HasColumnName("EXPR16");
			this.Property(t => t.EXPR17).HasColumnName("EXPR17");
			this.Property(t => t.EXPR18).HasColumnName("EXPR18");
			this.Property(t => t.EXPR19).HasColumnName("EXPR19");
			this.Property(t => t.EXPR20).HasColumnName("EXPR20");
			this.Property(t => t.EXPR21).HasColumnName("EXPR21");
			this.Property(t => t.EXPR22).HasColumnName("EXPR22");
			this.Property(t => t.EXPR23).HasColumnName("EXPR23");
			this.Property(t => t.EXPR24).HasColumnName("EXPR24");
			this.Property(t => t.EXPR25).HasColumnName("EXPR25");
			this.Property(t => t.EXPR26).HasColumnName("EXPR26");
			this.Property(t => t.EXPR27).HasColumnName("EXPR27");
			this.Property(t => t.EXPR28).HasColumnName("EXPR28");
			this.Property(t => t.EXPR29).HasColumnName("EXPR29");
			this.Property(t => t.EXPR30).HasColumnName("EXPR30");
			this.Property(t => t.EXPR31).HasColumnName("EXPR31");
			this.Property(t => t.EXPR32).HasColumnName("EXPR32");
			this.Property(t => t.EXPR33).HasColumnName("EXPR33");
			this.Property(t => t.EXPR35).HasColumnName("EXPR35");
			this.Property(t => t.EXPR36).HasColumnName("EXPR36");
			this.Property(t => t.EXPR37).HasColumnName("EXPR37");
		}
	}
}

