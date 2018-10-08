using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NearbyNowWebFormsExample
{
    public partial class CityPageOne : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException("You need to supply the city/state params below then remove this exception");

            var wc = new WebClient();
            var html = wc.DownloadString(
                String.Format(api,
                HttpUtility.UrlEncode(StorefrontToken),
                HttpUtility.UrlEncode("AZ"), // State, example: AZ
                HttpUtility.UrlEncode("Mesa"), // City, example: Phoenix
                "9",   //  zoomlevel
                "yes",   //  showmap
                "",   //  techemail
                "yes",   //  mapscrollwheel
                "",   //  fblike
                "",   //  fbcomment
                HttpUtility.UrlEncode(Request.UserAgent), //user agent
                "" // count
                )
            );

            NearbyNowLiteral.Text = html;
        }
    }
}