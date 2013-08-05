using System;
using DevExpress.ExpressApp.Layout;
using Microsoft.Practices.ServiceLocation;

namespace XMVVM.ExpressApp.Tests.TestMothers
{
    public class XMVVMApplicationMockedInstance : XMVVMApplication
    {
        protected override LayoutManager CreateLayoutManagerCore(bool simple)
        {
            throw new NotImplementedException();
        }
        public override IServiceLocator GetServiceLocator()
        {
            return _ServiceLocator;
        }

        internal IServiceLocator _ServiceLocator { get; set; }
    }
}