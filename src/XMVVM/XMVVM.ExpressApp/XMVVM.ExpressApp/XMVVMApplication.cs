using DevExpress.ExpressApp;
using Microsoft.Practices.ServiceLocation;
using XMMVM.Data;

namespace XMVVM.ExpressApp
{
    public abstract class XMVVMApplication : XafApplication, IServiceLocatorProvider
    {
        public IServiceLocator ServiceLocator { get; protected set; }

        protected XMVVMApplication(IServiceLocator serviceLocator)
        {
            ServiceLocator = serviceLocator;
        }
        protected XMVVMApplication() : this(Microsoft.Practices.ServiceLocation.ServiceLocator.Current) { }
    }
}