using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamShelterProject.Startup))]
namespace TeamShelterProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
