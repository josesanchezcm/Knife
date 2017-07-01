using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongdfApp.Core.Entities.Foundation;

namespace KongdfApp.Core.Entities
{
	public class Resume : BaseEntity
	{
		public int Version { get; set; }
		
		public string AbstractIntroduction { get; set; }

		public string SpecialSkills { get; set; }//Consider to extract it as a entity

		public string WorkExperiences { get; set; }//Consider to extract it as a entity

		public string Hobbies { get; set; }

		public int ColleagueId { get; set; }

		public virtual Colleague Colleague { get; set; }
	}
}
