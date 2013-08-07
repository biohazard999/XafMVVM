using DevExpress.ExpressApp.Web;
using Microsoft.Practices.ServiceLocation;
using XMMVM.Data;

namespace XMVVM.ExpressApp.Web
{
    public class XMVVMWebApplication : WebApplication, IServiceLocatorProvider
    {
        public IServiceLocator ServiceLocator { get; protected set; }

        public XMVVMWebApplication() : this(Microsoft.Practices.ServiceLocation.ServiceLocator.Current)
        {
            
        }

        public XMVVMWebApplication(IServiceLocator serviceLocator)
        {
            ServiceLocator = serviceLocator;
        }
    }
}