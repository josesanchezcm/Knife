using System;
using System.Data.Entity;
using KongdfApp.Core.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KongdfApp.Data
{
	public class BigBangInitializer : CreateDatabaseIfNotExists<KongdfAppDbContext>
	{
		protected override void Seed(KongdfAppDbContext context) {
			Initialize(context);
			base.Seed(context);
		}

		public void Initialize(KongdfAppDbContext context) {
			try {
				var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
				userManager.UserValidator = new UserValidator<ApplicationUser>(userManager) {
					AllowOnlyAlphanumericUserNames = false
				};
				var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

				if ( !roleManager.RoleExists("Admin") ) {
					roleManager.Create(new IdentityRole("Admin"));
				}

				if ( !roleManager.RoleExists("Member") ) {
					roleManager.Create(new IdentityRole("Member"));
				}

				var user = new ApplicationUser() {
					Email = "francismaustria@gmail.com",
					UserName = "test@test.com",
					FirstName = "Francis",
					LastName = "Austria"
				};

				var userResult = userManager.Create(user, "Admin@123");

				if ( userResult.Succeeded ) {
					userManager.AddToRole(user.Id, "Admin");
				}



				context.Commit();
			}
			catch ( Exception ex ) {

				throw ex;
			}
		}
	}
}
