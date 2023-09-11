using Autofac.Integration.Mvc;
using Autofac;
using ShopNow.Repository.Common.Repository.Impl;
using ShopNow.Repository.Common.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace ShopNow.WebUI.App_Start
{
    public class AutoFacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            //builder.RegisterType<ProductRepository>().As<IProductRepository>();


            var assembly = Assembly.Load("ShopNow.Repository");
            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Repository"))
                .ToList()
                .ForEach(t => builder.RegisterType(t).AsImplementedInterfaces().InstancePerDependency());


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}