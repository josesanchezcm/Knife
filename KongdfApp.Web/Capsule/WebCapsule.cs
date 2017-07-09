using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using KongdfApp.Core.Logging;
using KongdfApp.Data;
using KongdfApp.Logging.Logging;
using KongdfApp.Web.Capsule.Modules;

namespace KongdfApp.Web.Capsule
{
	public class WebCapsule
    {
        public void Initialize()
        {
            var builder = new ContainerBuilder();

            const string nameOrConnectionString = "name=KongdfAppDbConnection";
            builder.Register(b =>
            {
                var logger = b.ResolveOptional<ILogger>();
                var context = new KongdfAppDbContext(nameOrConnectionString, logger);
                return context;
            }).InstancePerLifetimeScope();

            builder.Register(b => NLogLogger.Instance).SingleInstance();
			
            builder.RegisterModule<ServiceCapsuleModule>();
            builder.RegisterModule<ControllerCapsuleModule>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}