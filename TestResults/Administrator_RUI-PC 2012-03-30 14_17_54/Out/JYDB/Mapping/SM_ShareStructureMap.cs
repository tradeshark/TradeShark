using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class SM_ShareStructureMap : EntityTypeConfiguration<SM_ShareStructure>
	{
		public SM_ShareStructureMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.DataTypeName)
				.HasMaxLength(50);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("SM_ShareStructure");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.DataTypeName).HasColumnName("DataTypeName");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.SponsorLegalPersonShares).HasColumnName("SponsorLegalPersonShares");
			this.Property(t => t.StateOwnedShares).HasColumnName("StateOwnedShares");
			this.Property(t => t.DomLegalPersonShares).HasColumnName("DomLegalPersonShares");
			this.Property(t => t.ForLegalPersonShares).HasColumnName("ForLegalPersonShares");
			this.Property(t => t.OtherLegalPersonShares).HasColumnName("OtherLegalPersonShares");
			this.Property(t => t.PrivPlaceLegalPersonShares).HasColumnName("PrivPlaceLegalPersonShares");
			this.Property(t => t.StaffShares).HasColumnName("StaffShares");
			this.Property(t => t.AlterRightIssueShares).HasColumnName("AlterRightIssueShares");
			this.Property(t => t.FormerOTCNonnegotiableShares).HasColumnName("FormerOTCNonnegotiableShares");
			this.Property(t => t.SpecificallyIssueSharesFund).HasColumnName("SpecificallyIssueSharesFund");
			this.Property(t => t.StratagemInvestorsShares).HasColumnName("StratagemInvestorsShares");
			this.Property(t => t.OtherNonnegotiableShares).HasColumnName("OtherNonnegotiableShares");
			this.Property(t => t.TotalNonnegotiableShares).HasColumnName("TotalNonnegotiableShares");
			this.Property(t => t.A_Shares).HasColumnName("A_Shares");
			this.Property(t => t.B_Shares).HasColumnName("B_Shares");
			this.Property(t => t.H_Shares).HasColumnName("H_Shares");
			this.Property(t => t.OtherNegotiableShares).HasColumnName("OtherNegotiableShares");
			this.Property(t => t.TotalNegotiableShares).HasColumnName("TotalNegotiableShares");
			this.Property(t => t.TotalCapital).HasColumnName("TotalCapital");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

