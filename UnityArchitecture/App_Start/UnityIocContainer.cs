using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using UnityArchitecture.BAL.Interfaces;
using UnityArchitecture.BAL.Services;
using UnityArchitecture.DependencyService;

namespace UnityArchitecture.App_Start
{
    public static class UnityIocContainer 
    {

        public static void ConfigIocContainer()
        {
            IUnityContainer container = new UnityContainer();

            RegisterService(container);

            DependencyResolver.SetResolver(new UnityResolver(container));
        }

        private static void RegisterService(IUnityContainer container)
        {
            container.RegisterType<ICustomerService, CustomerService>();

        }
    }
}