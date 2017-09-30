using System.Reflection;
using Autofac;
using Knife.Service.Services;
using Knife.Service.Services.Base;

namespace Knife.Web.Capsule.Modules
{
	public class ServiceCapsuleModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder) {
			builder.RegisterAssemblyTypes(Assembly.Load("Knife.Service")).
				Where(t => t.Name.EndsWith("Service")).
				AsImplementedInterfaces().
				InstancePerLifetimeScope();
		}
	}
}