using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGithub.Startup))]
namespace testGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
