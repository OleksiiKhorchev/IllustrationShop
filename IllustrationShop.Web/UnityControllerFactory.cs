using System;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace IllustrationShop.Web
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        readonly IUnityContainer _container;

        public UnityControllerFactory(IUnityContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,
            Type controllerType)
        {
            if (controllerType != null)
                return _container.Resolve(controllerType) as IController;

            return base.GetControllerInstance(requestContext, controllerType);
        }

        // No need to override ReleaseController - it is properly implemented in base DefaultControllerFactory
        // to dispose IDisposable dependencies
    }
}