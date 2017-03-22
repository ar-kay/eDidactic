using System;
using System.Collections.Generic;
using System.Web.Mvc;
using eDidactic.Domain.Abstract;
using eDidactic.Domain.Concrete;
using eDidactic.Domain.Entities;
using Moq;
using Ninject;

namespace eDidactic.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<ICourseRepository>().To<EFCourseRepository>();
        }
    }
}