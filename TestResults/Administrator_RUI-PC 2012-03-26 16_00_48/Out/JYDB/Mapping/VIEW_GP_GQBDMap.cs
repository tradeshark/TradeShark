using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_GP_GQBDMap : EntityTypeConfiguration<VIEW_GP_GQBD>
	{
		public VIEW_GP_GQBDMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_IfSuspended, t.ID, t.CompanyCode, t.InfoPublDate, t.XGRQ });

			// Properties
			this.Property(t => t.N_TranMode)
				.HasMaxLength(300);
				
			this.Property(t => t.N_TranShareType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfSuspended)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.TransfererName)
				.HasMaxLength(100);
				
			this.Property(t => t.ReceiverName)
				.HasMaxLength(100);
				
			this.Property(t => t.ValidCondition)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("VIEW_GP_GQBD");
			this.Property(t => t.N_TranMode).HasColumnName("N_TranMode");
			this.Property(t => t.N_TranShareType).HasColumnName("N_TranShareType");
			this.Property(t => t.N_IfSuspended).HasColumnName("N_IfSuspended");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ContractSignDate).HasColumnName("ContractSignDate");
			this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
			this.Property(t => t.TranDate).HasColumnName("TranDate");
			this.Property(t => t.TransfererName).HasColumnName("TransfererName");
			this.Property(t => t.TansfererEcoNature).HasColumnName("TansfererEcoNature");
			this.Property(t => t.TranShareType).HasColumnName("TranShareType");
			this.Property(t => t.SumBeforeTran).HasColumnName("SumBeforeTran");
			this.Property(t => t.PCTBeforeTran).HasColumnName("PCTBeforeTran");
			this.Property(t => t.SumAfterTran).HasColumnName("SumAfterTran");
			this.Property(t => t.PCTAfterTran).HasColumnName("PCTAfterTran");
			this.Property(t => t.ReceiverName).HasColumnName("ReceiverName");
			this.Property(t => t.ReceiverEcoNature).HasColumnName("ReceiverEcoNature");
			this.Property(t => t.SumAfterRece).HasColumnName("SumAfterRece");
			this.Property(t => t.PCTAfterRece).HasColumnName("PCTAfterRece");
			this.Property(t => t.TranMode).HasColumnName("TranMode");
			this.Property(t => t.InvolvedSum).HasColumnName("InvolvedSum");
			this.Property(t => t.PCTOfTansferer).HasColumnName("PCTOfTansferer");
			this.Property(t => t.PCTOfTotalShares).HasColumnName("PCTOfTotalShares");
			this.Property(t => t.DealPrice).HasColumnName("DealPrice");
			this.Property(t => t.DealTurnover).HasColumnName("DealTurnover");
			this.Property(t => t.ValidCondition).HasColumnName("ValidCondition");
			this.Property(t => t.TranStatement).HasColumnName("TranStatement");
			this.Property(t => t.IfSuspended).HasColumnName("IfSuspended");
			this.Property(t => t.SuspendedPublDate).HasColumnName("SuspendedPublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

