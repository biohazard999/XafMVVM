using System;
using System.Collections.Generic;
using DevExpress.ExpressApp;
using XMVVM.ExpressApp.SystemModule.Controllers;

namespace XMVVM.ExpressApp.SystemModule
{
    public class XafMVVMModule : ModuleBase
    {
        protected override IEnumerable<Type> GetDeclaredExportedTypes()
        {
            return new Type[] {};
        }

        protected override IEnumerable<Type> GetDeclaredControllerTypes()
        {
            return new []
            {
                typeof(MVVMNagivationItemController),
            };
        }
    }
}
