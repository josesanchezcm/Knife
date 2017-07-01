namespace KongdfApp.Data.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<KongdfApp.Data.KongdfAppDbContext>
	{
		public Configuration() {
			AutomaticMigrationsEnabled = false;
			ContextKey = nameof(KongdfAppDbContext);
		}

		protected override void Seed(KongdfApp.Data.KongdfAppDbContext context) {
			base.Seed(context);
		}
	}
}
