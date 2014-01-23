using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerFestTestEntityCodeFirst.Startup))]
namespace BeerFestTestEntityCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
