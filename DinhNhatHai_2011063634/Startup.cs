using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DinhNhatHai_2011063634.Startup))]
namespace DinhNhatHai_2011063634
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
