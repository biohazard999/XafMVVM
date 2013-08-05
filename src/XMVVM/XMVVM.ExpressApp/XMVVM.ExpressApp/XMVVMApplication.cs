using DevExpress.ExpressApp;
using Microsoft.Practices.ServiceLocation;

namespace XMVVM.ExpressApp
{
    public abstract class XMVVMApplication : XafApplication
    {
        public virtual IServiceLocator GetServiceLocator()
        {
            return null;
        }

    }
}