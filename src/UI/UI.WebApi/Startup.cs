using System.Web.Http;
using Ioc;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace UI.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            ConfigureRoute(config);
            ConfigureIoc(config);
            app.UseWebApi(config);
        }

        private void ConfigureRoute(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private void ConfigureIoc(HttpConfiguration conf)
        {
            var container = new Container();
            
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            container.Initialize(new WebApiRequestLifestyle());

            container.RegisterWebApiControllers(conf);
            
            container.Verify();

            conf.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
