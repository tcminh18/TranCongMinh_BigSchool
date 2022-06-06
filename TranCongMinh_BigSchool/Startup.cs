using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranCongMinh_BigSchool.Startup))]
namespace TranCongMinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
