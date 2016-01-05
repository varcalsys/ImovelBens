using ImovelBens.CrossCutting.IoC.SimpleInjectorConfig;
using ImovelBens.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace ImovelBens.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SimpleInjectorInitializer.Initialize();
        }
    }
}
