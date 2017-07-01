using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities.Foundation;

namespace KongdfApp.Core.Entities
{
	public class Colleague : BaseEntity
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string Telephone { get; set; }

		public string MobilePhone { get; set; }

		public string Address { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Resume> Resumes { get; set; }
	}
}
