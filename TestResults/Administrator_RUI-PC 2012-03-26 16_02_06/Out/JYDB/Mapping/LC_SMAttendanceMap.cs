using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_SMAttendanceMap : EntityTypeConfiguration<LC_SMAttendance>
	{
		public LC_SMAttendanceMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Address)
				.HasMaxLength(100);
				
			this.Property(t => t.NetVotingCode)
				.HasMaxLength(50);
				
			this.Property(t => t.VotingAbbr)
				.HasMaxLength(50);
				
			this.Property(t => t.Presider)
				.HasMaxLength(50);
				
			this.Property(t => t.TestmonyLawOffice)
				.HasMaxLength(200);
				
			this.Property(t => t.Lawyer)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("LC_SMAttendance");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AnounceDate).HasColumnName("AnounceDate");
			this.Property(t => t.MeetingDate).HasColumnName("MeetingDate");
			this.Property(t => t.Address).HasColumnName("Address");
			this.Property(t => t.MeetingType).HasColumnName("MeetingType");
			this.Property(t => t.VotingMeans).HasColumnName("VotingMeans");
			this.Property(t => t.NetVotingCode).HasColumnName("NetVotingCode");
			this.Property(t => t.VotingAbbr).HasColumnName("VotingAbbr");
			this.Property(t => t.Presider).HasColumnName("Presider");
			this.Property(t => t.PresiderOfficialPost).HasColumnName("PresiderOfficialPost");
			this.Property(t => t.TestmonyLawOffice).HasColumnName("TestmonyLawOffice");
			this.Property(t => t.LawOfficeCode).HasColumnName("LawOfficeCode");
			this.Property(t => t.Lawyer).HasColumnName("Lawyer");
			this.Property(t => t.AttendanceType).HasColumnName("AttendanceType");
			this.Property(t => t.AttendanceNumber).HasColumnName("AttendanceNumber");
			this.Property(t => t.ShareReprensented).HasColumnName("ShareReprensented");
			this.Property(t => t.RatioInTotalShare).HasColumnName("RatioInTotalShare");
			this.Property(t => t.NTSHNumber).HasColumnName("NTSHNumber");
			this.Property(t => t.ForeignNTSHNumber).HasColumnName("ForeignNTSHNumber");
			this.Property(t => t.NTSHRepresentedShare).HasColumnName("NTSHRepresentedShare");
			this.Property(t => t.FNTSHRepresentedShare).HasColumnName("FNTSHRepresentedShare");
			this.Property(t => t.TSHNumber).HasColumnName("TSHNumber");
			this.Property(t => t.ATSHNumber).HasColumnName("ATSHNumber");
			this.Property(t => t.BTSHNumber).HasColumnName("BTSHNumber");
			this.Property(t => t.HTSHNumber).HasColumnName("HTSHNumber");
			this.Property(t => t.OtherTSHNumber).HasColumnName("OtherTSHNumber");
			this.Property(t => t.TSHRepresentedShare).HasColumnName("TSHRepresentedShare");
			this.Property(t => t.ATSHRepresentedShare).HasColumnName("ATSHRepresentedShare");
			this.Property(t => t.BTSHRepresentedShare).HasColumnName("BTSHRepresentedShare");
			this.Property(t => t.HTSHRepresentedShare).HasColumnName("HTSHRepresentedShare");
			this.Property(t => t.OtherTSHRepresentedShare).HasColumnName("OtherTSHRepresentedShare");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.SMRegDate).HasColumnName("SMRegDate");
		}
	}
}

