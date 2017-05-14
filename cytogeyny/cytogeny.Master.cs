using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cytogeyny
{
    public partial class cytogeny : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SetCurrentPage();
        }

        private void SetCurrentPage()
        {
            var pageName = GetPageName();

            switch (pageName)
            {
                //case "index.aspx":
                //    home.Attributes["class"] = "active";
                //    break;
                //case "services.aspx":
                //    service.Attributes["class"] = "active";
                //    break;
                //case "portfolio.aspx":
                //    pp.Attributes["class"] = "active";
                //    break;
                //case "blog.aspx":
                //    blog.Attributes["class"] = "active";
                //    break;
                //case "contact.aspx":
                //    contact.Attributes["class"] = "active";
                //    break;
            }
        }

        private string GetPageName()
        {
            return Request.Url.ToString().Split('/').Last();
        }
    }
}