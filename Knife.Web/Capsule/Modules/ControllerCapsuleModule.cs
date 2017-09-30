using Autofac;
using System.Reflection;
using Autofac.Integration.Mvc;

namespace Knife.Web.Capsule.Modules
{
	public class ControllerCapsuleModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

			// Register the MVC Controllers
			//builder.RegisterControllers(Assembly.Load("Knife.Web"));

			// Register the Web API Controllers
			//builder.RegisterApiControllers(Assembly.GetCallingAssembly());
			builder.RegisterControllers(Assembly.Load("Knife.Web"));
        }
    }
}