using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalOrganizerMVC.Startup))]
namespace PersonalOrganizerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
