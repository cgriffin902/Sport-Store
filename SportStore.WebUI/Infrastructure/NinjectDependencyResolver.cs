using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.Domain.Concreate;
namespace SportStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernal;
        public NinjectDependencyResolver(IKernel kernalParam)
        {
            kernal = kernalParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernal.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernal.GetAll(serviceType);
        }
        public void AddBindings()
        {
            //put bindings here
            kernal.Bind<IProductsRepository>().To<EFProductRepository>();

        }
    }
}