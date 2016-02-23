using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IbitiTec.Startup))]
namespace IbitiTec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
