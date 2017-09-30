using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Knife.Core.Logging;
using Knife.Data;
using Knife.Logging.Logging;
using Knife.Web.Capsule.Modules;

namespace Knife.Web.Capsule
{
	public class WebCapsule
    {
        public void Initialize()
        {
            var builder = new ContainerBuilder();

            const string nameOrConnectionString = "name=KnifeDbConnection";
            builder.Register(b =>
            {
                var logger = b.ResolveOptional<ILogger>();
                var context = new KnifeDbContext(nameOrConnectionString, logger);
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