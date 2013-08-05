using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using Xpand.ExpressApp.XafMVVM.Controllers;

namespace Xpand.ExpressApp.XafMVVM
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
