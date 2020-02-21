using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOF005_Tarea4.Startup))]
namespace SOF005_Tarea4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
