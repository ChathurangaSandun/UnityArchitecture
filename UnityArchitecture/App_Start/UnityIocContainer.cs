using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using UnityArchitecture.BAL.Interfaces;
using UnityArchitecture.BAL.Services;
using UnityArchitecture.DAL;
using UnityArchitecture.DAL.Common;
using UnityArchitecture.DAL.Interfaces;
using UnityArchitecture.DAL.Repository;
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

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<DbContext,UnityDbContext>();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            container.RegisterType<ICustomerService, CustomerService>();

        }
    }
}