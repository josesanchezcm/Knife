using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using KongdfApp.Core.Entities;
using KongdfApp.Data;
using KongdfApp.Service.Services.Base;

namespace KongdfApp.Service.Services
{
	public class ColleagueService : BaseService<Colleague>, IColleagueService
	{
		protected KongdfAppDbContext _context;
		protected IDbSet<Colleague> _dbset;
		public ColleagueService(KongdfAppDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Colleague>();
		}
		
		public virtual async Task<List<Colleague>> GetAllAsync() {
			return await _dbset.ToListAsync();
		}
	}
}
