using KongdfApp.Core.Data.Repositories;
using KongdfApp.Core.Entities;

namespace KongdfApp.Data.Repositories
{
	public class ColleagueRepository : BaseRepository<Colleague>, IColleagueRepository
	{
		public ColleagueRepository(IDbContext context) : base(context) {
		}
	}
}
