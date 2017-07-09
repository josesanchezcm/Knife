using KongdfApp.Web.Capsule;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KongdfApp.Web.Startup))]
namespace KongdfApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			
			new WebCapsule().Initialize();
		}
    }
}
