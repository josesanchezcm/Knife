using KongdfApp.Core.Data.Repositories;
using KongdfApp.Core.Entities;

namespace KongdfApp.Data.Repositories
{
	public class ResumeRepository : BaseRepository<Resume>, IResumeRepository
	{
		public ResumeRepository(IDbContext context) : base(context) {
		}
	}
}
