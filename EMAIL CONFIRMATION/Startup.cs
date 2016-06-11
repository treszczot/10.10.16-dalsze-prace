using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMAIL_CONFIRMATION.Startup))]
namespace EMAIL_CONFIRMATION
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
