﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities.Foundation;

namespace KongdfApp.Core.Data.Repositories
{
	public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
	{
		Task<List<TEntity>> GetAllAsync();

		Task<TEntity> GetByIdAsync(int id);

		void Add(TEntity entity);

		void Update(TEntity entity);

		void Delete(TEntity entity);
	}
}
