using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Terrarium.Server
{
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Gets this party started.
        /// </summary>
        /// <remarks>
        /// The database will be created (locally) automatically but
        /// if you want to seed the database with some values just
        /// add this line below:
        /// <code>
        ///     System.Data.Entity.Database.SetInitializer(new TerrariumDbSeedInitializer());
        /// </code>
        /// and modify the TerrariumDbSeedInitiailizer class with whatever values you want.
        /// </remarks>
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            MvcHandler.DisableMvcResponseHeader = true;
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.RegisterContainers();
        }
    }
}