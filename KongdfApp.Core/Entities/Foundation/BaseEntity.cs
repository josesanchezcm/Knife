using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongdfApp.Core.Entities.Foundation
{
	public abstract class BaseEntity : IEntity
	{
		[Key]
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
