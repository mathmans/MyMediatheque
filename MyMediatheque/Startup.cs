using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMediatheque.Startup))]
namespace MyMediatheque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
