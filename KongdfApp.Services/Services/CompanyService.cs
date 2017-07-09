using System.Data.Entity;
using KongdfApp.Core.Entities;
using KongdfApp.Data;
using KongdfApp.Service.Services.Base;

namespace KongdfApp.Service.Services
{
	public class CompanyService : BaseService<Company>, ICompanyService
	{
		protected KongdfAppDbContext _context;
		protected IDbSet<Company> _dbset;
		public CompanyService(KongdfAppDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Company>();
		}
	}
}
