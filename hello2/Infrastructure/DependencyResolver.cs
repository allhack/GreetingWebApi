using System;
using System.Collections.Generic;
using System.Web.Mvc;
using hello2.Controllers;
using hello2.Models;
using Ninject;
using Ninject.Web.Common;

namespace hello2.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IGreeter>().To<HelloGreeter>().WhenInjectedInto<HelloController>();
            _kernel.Bind<IGreeter>().To<HiGreeter>().WhenInjectedInto<HiController>();
        }
    }
}