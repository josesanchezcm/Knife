﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knife.Core.Entities.Foundation
{
	public abstract class BaseEntity
	{

	}
	public abstract class Entity<T> : BaseEntity,IEntity<T>
	{
		[Key]
		public virtual T Id { get; set; }
	}
}
