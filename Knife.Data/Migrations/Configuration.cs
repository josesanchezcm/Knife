namespace Knife.Data.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<Knife.Data.KnifeDbContext>
	{
		public Configuration() {
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(Knife.Data.KnifeDbContext context) {
			base.Seed(context);
		}
	}
}
