using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongdfApp.Core.Entities.Foundation
{
	public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
	{
		public DateTime CreatedDate { get; set; }

		[MaxLength(256)]
		public string CreatedBy { get; set; }

		public DateTime UpdatedDate { get; set; }

		[MaxLength(256)]
		public string UpdatedBy { get; set; }
	}
}
