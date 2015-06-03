using Microsoft.Owin;
using Owin;
using ToDo.PL.MVC;

[assembly: OwinStartup(typeof(Startup))]

namespace ToDo.PL.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
