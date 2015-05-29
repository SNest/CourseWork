using Microsoft.Owin;
using Owin;
using ToDo.PL;

[assembly: OwinStartup(typeof(Startup))]

namespace ToDo.PL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
