using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace XMVVM.ExpressApp.Demos.Module.Web
{
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class XafMVVMAspNetModule : ModuleBase
    {
        public XafMVVMAspNetModule()
        {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
