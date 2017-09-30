using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Knife.Core.Entities;
using Knife.Data;
using Knife.Service.Services.Base;

namespace Knife.Service.Services
{
	public class ColleagueService : BaseService<Colleague>, IColleagueService
	{
		protected KnifeDbContext _context;
		protected IDbSet<Colleague> _dbset;
		public ColleagueService(KnifeDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Colleague>();
		}
		
		public virtual async Task<List<Colleague>> GetAllAsync() {
			return await _dbset.ToListAsync();
		}
	}
}
