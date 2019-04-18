using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaEncyclopediaInUrdu.Startup))]
namespace MediaEncyclopediaInUrdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
