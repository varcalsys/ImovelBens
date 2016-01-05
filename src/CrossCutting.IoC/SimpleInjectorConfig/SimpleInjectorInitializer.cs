﻿using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace ImovelBens.CrossCutting.IoC.SimpleInjectorConfig
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);


            //container.RegisterPerWebRequest(() =>
            //{
            //    if (HttpContext.Current != null && HttpContext.Current.Items["owin.Enviroment"] == null && container.IsVerifying)
            //    {
            //        return new OwinContext().Authentication;
            //    }

            //    return HttpContext.Current.GetOwinContext().Authentication;
            //});

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}
