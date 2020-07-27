using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NearbyNowWebFormsExample
{
    public partial class Faq : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var wc = new WebClient();

            var html = wc.DownloadString(
                String.Format("http://localhost:50899/plugin/faq?storefronttoken={0}&topic={1}&count={2}",
                HttpUtility.UrlEncode(StorefrontToken),
                HttpUtility.UrlEncode("mobile-apps"),// topic
                3 //count
                )
            );

            NearbyNowLiteral.Text = html;
        }
    }
}