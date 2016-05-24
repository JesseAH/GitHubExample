using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubExample.Startup))]
namespace GitHubExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
