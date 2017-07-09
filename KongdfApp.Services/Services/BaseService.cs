using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using KongdfApp.Core.Entities.Foundation;
using KongdfApp.Data;
using KongdfApp.Service.Services.Base;

namespace KongdfApp.Service.Services
{
	public abstract class BaseService<TEntity> : IService<TEntity> where TEntity : BaseEntity
	{
		protected KongdfAppDbContext _context;
		protected IDbSet<TEntity> _dbset;

		public BaseService(KongdfAppDbContext context) {
			_context = context;
			_dbset = _context.Set<TEntity>();
		}

		public virtual TEntity Add(TEntity entity) {
			if ( entity == null ) {
				throw new ArgumentNullException("entity");
			}

			_dbset.Add(entity);
			_context.SaveChanges();

			return entity;
		}

		public virtual void Update(TEntity entity) {
			if ( entity == null ) throw new ArgumentNullException("entity");
			_context.Entry(entity).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public virtual void Delete(TEntity entity) {
			if ( entity == null ) throw new ArgumentNullException("entity");
			_dbset.Remove(entity);
			_context.SaveChanges();
		}

		public virtual List<TEntity> GetAll() {
			return _dbset.ToList();
		}
	}
}
