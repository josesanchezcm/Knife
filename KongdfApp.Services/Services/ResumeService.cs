using KongdfApp.Core.Data;
using KongdfApp.Core.Entities;
using KongdfApp.Core.Services;

namespace KongdfApp.Services.Services
{
	public class ResumeService : BaseService<Resume>, IResumeService
	{
		public ResumeService(IUnitOfWork unitOfWork) : base(unitOfWork) {
		}
	}
}
