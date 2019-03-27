using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NghiaNgo_BigSchool.Startup))]
namespace NghiaNgo_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
