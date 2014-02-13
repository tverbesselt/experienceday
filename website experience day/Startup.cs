using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(website_experience_day.Startup))]
namespace website_experience_day
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
