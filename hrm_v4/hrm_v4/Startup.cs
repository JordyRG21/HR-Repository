using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hrm_v4.Startup))]
namespace hrm_v4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
