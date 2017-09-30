using System.Data.Entity;
using Knife.Core.Entities;
using Knife.Data;
using Knife.Service.Services.Base;

namespace Knife.Service.Services
{
	public class ResumeService : BaseService<Resume>, IResumeService
	{
		protected KnifeDbContext _context;
		protected IDbSet<Resume> _dbset;
		public ResumeService(KnifeDbContext context) : base(context) {
			_context = context;
			_dbset = _context.Set<Resume>();
		}
	}
}
