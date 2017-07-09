using System.Data.Entity;
using KongdfApp.Core.Entities;
using KongdfApp.Data;
using KongdfApp.Service.Services.Base;

namespace KongdfApp.Service.Services
{
	public class ResumeService : BaseService<Resume>, IResumeService
	{
		protected KongdfAppDbContext _context;
		protected IDbSet<Resume> _dbset;
		public ResumeService(KongdfAppDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Resume>();
		}
	}
}
