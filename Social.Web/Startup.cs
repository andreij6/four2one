using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social.Web.Startup))]
namespace Social.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
            
        }
    }
}
