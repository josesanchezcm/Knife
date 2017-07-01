using KongdfApp.Core.Data;
using KongdfApp.Core.Entities;
using KongdfApp.Core.Services;

namespace KongdfApp.Services.Services
{
	public class CompanyService : BaseService<Company>, ICompanyService
	{
		public CompanyService(IUnitOfWork unitOfWork) : base(unitOfWork) {
		}
	}
}
