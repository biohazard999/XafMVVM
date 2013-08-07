using DevExpress.ExpressApp.Win;
using Microsoft.Practices.ServiceLocation;
using XMMVM.Data;

namespace XMVVM.ExpressApp.Win
{
    public class XMVVMWinApplication : WinApplication, IServiceLocatorProvider
    {
        public IServiceLocator ServiceLocator { get; protected set; }

        public XMVVMWinApplication() : this(Microsoft.Practices.ServiceLocation.ServiceLocator.Current)
        {
            
        }

        public XMVVMWinApplication(IServiceLocator serviceLocator)
        {
            ServiceLocator = serviceLocator;
        }
    }
}