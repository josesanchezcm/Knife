using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities;

namespace KongdfApp.Data.Configurations
{
	public class CompanyConfiguration : EntityTypeConfiguration<Company>
	{
		public CompanyConfiguration() {
			Property(c => c.Name).IsRequired().HasMaxLength(100);
			Property(c => c.Email).IsRequired().HasMaxLength(250);
			Property(c => c.Telephone).HasMaxLength(150);
			Property(c => c.OfficialWebsite).HasMaxLength(250);
			Property(c => c.Description).HasMaxLength(250);
		}
	}
}
