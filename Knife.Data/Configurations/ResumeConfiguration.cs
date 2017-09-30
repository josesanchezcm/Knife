using System.Data.Entity.ModelConfiguration;
using Knife.Core.Entities;

namespace Knife.Data.Configurations
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
