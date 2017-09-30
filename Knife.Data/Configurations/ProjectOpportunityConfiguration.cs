using System.Data.Entity.ModelConfiguration;
using Knife.Data.Entities;

namespace Knife.Data.Configurations
{
	public class ProjectOpportunityConfiguration : EntityTypeConfiguration<ProjectOpportunity>
	{
		public ProjectOpportunityConfiguration() {
			Property(c => c.Name).IsRequired();
			Property(c => c.Owner).IsRequired().HasMaxLength(150);
			Property(c => c.Contact).IsRequired().HasMaxLength(150);
			Property(c => c.Descript).HasMaxLength(250);
		}
	}
}
