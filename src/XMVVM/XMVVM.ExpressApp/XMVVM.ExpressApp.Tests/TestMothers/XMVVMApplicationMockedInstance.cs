using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Layout;
using Microsoft.Practices.ServiceLocation;

namespace XMVVM.ExpressApp.Tests.TestMothers
{
    public class XMVVMApplicationMockedInstance : XMVVMApplication
    {
        public XMVVMApplicationMockedInstance(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }

        public XMVVMApplicationMockedInstance()
        {
        }

        protected override LayoutManager CreateLayoutManagerCore(bool simple)
        {
            throw new NotImplementedException();
        }
        
    }
}