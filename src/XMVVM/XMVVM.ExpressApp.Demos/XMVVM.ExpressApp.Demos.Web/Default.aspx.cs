using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web.Templates;

namespace XMVVM.ExpressApp.Demos.Web
{
    public partial class Default : BaseXafPage
    {
        protected override ContextActionsMenu CreateContextActionsMenu()
        {
            return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
        }
        public override Control InnerContentPlaceHolder
        {
            get
            {
                return Content;
            }
        }
    }
}
