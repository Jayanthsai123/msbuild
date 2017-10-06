using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsSolution.Startup))]
namespace DevOpsSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
