using System.Data.Entity.ModelConfiguration;
using Knife.Core.Entities;

namespace Knife.Data.Configurations
{
	public class ColleagueConfiguration : EntityTypeConfiguration<Colleague>
	{
		public ColleagueConfiguration() {
			Property(c => c.Name).IsRequired().HasMaxLength(100);
			Property(c => c.Email).IsRequired().HasMaxLength(250);
			Property(c => c.Telephone).HasMaxLength(150);
			Property(c => c.MobilePhone).IsRequired().HasMaxLength(250);
			Property(c => c.Address).IsRequired().HasMaxLength(250);
			Property(c => c.Description).HasMaxLength(250);
		}
	}
}
