using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities;

namespace KongdfApp.Data.Configurations
{
	public class ResumeConfiguration : EntityTypeConfiguration<Resume>
	{
		public ResumeConfiguration() {
			Property(c => c.Version).IsRequired();
			Property(c => c.ColleagueId).IsRequired();
			Property(c => c.AbstractIntroduction).HasMaxLength(250);
			Property(c => c.SpecialSkills).HasMaxLength(250);
			Property(c => c.WorkExperiences).HasMaxLength(500);
		}
	}
}
