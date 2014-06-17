using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Terrarium.Server.DataModels;

namespace Terrarium.Server
{
    public class ContainerConfig
    {
        public static void RegisterContainers()
        {
            var builder = new ContainerBuilder();

            // register all controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // register the database context
            builder.RegisterType<TerrariumDbContext>()
                .As<ITerrariumDbContext>()
                .InstancePerLifetimeScope();

            // register any repositories via namespace
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(x => x.Namespace != null && x.Namespace.EndsWith(".Repositories"))
                .AsImplementedInterfaces();

            // build up the container and resolve dependencies
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}