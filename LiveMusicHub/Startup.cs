using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveMusicHub.Startup))]
namespace LiveMusicHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
