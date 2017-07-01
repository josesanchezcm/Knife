using KongdfApp.Core.Data.Repositories;
using KongdfApp.Core.Entities;

namespace KongdfApp.Data.Repositories
{
	public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
	{
		public CompanyRepository(IDbContext context) : base(context) {
		}
	}
}
