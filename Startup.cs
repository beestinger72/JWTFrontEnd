using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JWTFrontEnd.Startup))]
namespace JWTFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
