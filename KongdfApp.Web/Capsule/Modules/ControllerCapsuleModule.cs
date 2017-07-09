using Autofac;
using System.Reflection;
using Autofac.Integration.Mvc;

namespace KongdfApp.Web.Capsule.Modules
{
	public class ControllerCapsuleModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

			// Register the MVC Controllers
			//builder.RegisterControllers(Assembly.Load("KongdfApp.Web"));

			// Register the Web API Controllers
			//builder.RegisterApiControllers(Assembly.GetCallingAssembly());
			builder.RegisterControllers(Assembly.Load("KongdfApp.Web"));
        }
    }
}