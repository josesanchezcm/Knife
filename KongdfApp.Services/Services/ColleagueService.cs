using KongdfApp.Core.Data;
using KongdfApp.Core.Entities;
using KongdfApp.Core.Services;

namespace KongdfApp.Services.Services
{
	public class ColleagueService : BaseService<Colleague>, IColleagueService
	{
		public ColleagueService(IUnitOfWork unitOfWork) : base(unitOfWork) {
		}
	}
}
