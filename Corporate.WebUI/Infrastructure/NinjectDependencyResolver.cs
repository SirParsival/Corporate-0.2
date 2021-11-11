using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using Corporate.Domain.Abstract;
using Corporate.Domain.Entities;
using Corporate.Domain.Concrete;

namespace Corporate.WebUI.Infrastructure
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
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //  new Product { Title = "SimCity", Price = 1499 },
            //  new Product { Title = "TITANFALL", Price=2299 },
            //  new Product { Title = "Battlefield 4", Price=899.4M }
            //});
            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            // Здесь размещаются привязки
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}