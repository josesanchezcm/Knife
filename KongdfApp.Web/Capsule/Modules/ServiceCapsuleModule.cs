using System.Reflection;
using Autofac;
using KongdfApp.Service.Services;
using KongdfApp.Service.Services.Base;

namespace KongdfApp.Web.Capsule.Modules
{
	public class ServiceCapsuleModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder) {
			builder.RegisterAssemblyTypes(Assembly.Load("KongdfApp.Service")).
				Where(t => t.Name.EndsWith("Service")).
				AsImplementedInterfaces().
				InstancePerLifetimeScope();
		}
	}
}