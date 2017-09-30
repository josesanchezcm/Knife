using System.Data.Entity;
using Knife.Core.Entities;
using Knife.Data;
using Knife.Service.Services.Base;

namespace Knife.Service.Services
{
	public class CompanyService : BaseService<Company>, ICompanyService
	{
		protected KnifeDbContext _context;
		protected IDbSet<Company> _dbset;
		public CompanyService(KnifeDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Company>();
		}
	}
}
