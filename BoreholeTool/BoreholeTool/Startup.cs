using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoreholeTool.Startup))]
namespace BoreholeTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
