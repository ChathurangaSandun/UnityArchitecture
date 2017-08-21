using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace UnityArchitecture.DependencyService
{
    public class UnityResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;
        public UnityResolver(IUnityContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {

            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (Exception e)
            {
                return new List<object>();
            }
        }
    }
}