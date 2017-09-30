using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knife.Core.Entities.Foundation;

namespace Knife.Core.Entities
{
	public class Company : AuditableEntity<int>
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string Telephone { get; set; }

		public string OfficialWebsite { get; set; }

		public string Description { get; set; }
	}
}
