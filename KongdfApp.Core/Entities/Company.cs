using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities.Foundation;

namespace KongdfApp.Core.Entities
{
	public class Company : BaseEntity
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string Telephone { get; set; }

		public string OfficialWebsite { get; set; }

		public string Description { get; set; }
	}
}
