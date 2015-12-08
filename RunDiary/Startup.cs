using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunDiary.Startup))]
namespace RunDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
