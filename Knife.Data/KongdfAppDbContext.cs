using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration;
using Knife.Core.Entities;
using Knife.Core.Logging;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using Knife.Core.Entities.Foundation;
using System.Threading;

namespace Knife.Data
{
	public class KnifeDbContext : IdentityDbContext<ApplicationUser>
	{
		static readonly object Lock = new object();
		static bool _databaseInitialized;

		public KnifeDbContext()
			: base("KnifeDbConnection") {
		}

		public KnifeDbContext(string nameOrConnectionString, ILogger logger)
			: base(nameOrConnectionString) {
			if ( logger != null ) {
				Database.Log = logger.Log;
			}

			if ( _databaseInitialized ) {
				return;
			}
			lock ( Lock ) {
				if ( !_databaseInitialized ) {
					Database.SetInitializer(new BigBangInitializer());
					_databaseInitialized = true;
				}
			}
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			var mappings = GetType().Assembly.GetTypes().Where(x => x.BaseType?.Name == typeof(EntityTypeConfiguration<>).Name).ToList();
			foreach ( var mapping in mappings ) {
				dynamic instance = Activator.CreateInstance(mapping);
				modelBuilder.Configurations.Add(instance);
			}
		}


		public override int SaveChanges() {
			var modifiedEntries = ChangeTracker.Entries()
				.Where(x => x.Entity is IAuditableEntity
					&& (x.State == EntityState.Added || x.State == EntityState.Modified));

			foreach ( var entry in modifiedEntries ) {
				IAuditableEntity entity = entry.Entity as IAuditableEntity;
				if ( entity != null ) {
					string identityName = Thread.CurrentPrincipal.Identity.Name;
					DateTime now = DateTime.UtcNow;

					if ( entry.State == EntityState.Added ) {
						entity.CreatedBy = identityName;
						entity.CreatedDate = now;
					}
					else {
						base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
						base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
					}

					entity.UpdatedBy = identityName;
					entity.UpdatedDate = now;
				}
			}

			return base.SaveChanges();
		}

		public static KnifeDbContext Create() {
			return new KnifeDbContext(nameOrConnectionString: "KnifeDbConnection", logger: null);
		}

		#region DbSets
		public virtual IDbSet<Colleague> Colleagues { get; set; }
		public virtual IDbSet<Company> Companys { get; set; }
		public virtual IDbSet<Resume> Resumes { get; set; }
		#endregion
	}
}
