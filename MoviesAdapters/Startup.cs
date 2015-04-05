using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesAdapters.Startup))]
namespace MoviesAdapters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
