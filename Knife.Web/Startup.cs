using Knife.Web.Capsule;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Knife.Web.Startup))]
namespace Knife.Web
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
