using System;
using System.Collections.Generic;
using System.Web.Mvc;
using eDidactic.Domain.Abstract;
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
            Mock<ICourseRepository> mock = new Mock<ICourseRepository>();
            mock.Setup(m => m.Course).Returns(new List<Course>
            {
                new Course {Name = "Język C#", Description = "Kurs programowania w języku C# dla początkujących.."},
                new Course {Name = "JavaScript", Description = "JavaScript dla zaawansowanych.. "},
                new Course {Name = "Pascal", Description = "Pascal w przykładach.."}
            });

            kernel.Bind<ICourseRepository>().ToConstant(mock.Object);
        }
    }
}