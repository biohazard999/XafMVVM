using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace XMVVM.ExpressApp.Demos.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class XafMVVMWindowsFormsModule : ModuleBase
    {
        public XafMVVMWindowsFormsModule()
        {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
