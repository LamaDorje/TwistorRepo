using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewTwistor.Startup))]
namespace NewTwistor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
