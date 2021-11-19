using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NearbyNowWebFormsExample
{
    public partial class Nationwide : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var wc = new WebClient();
            //var html = wc.DownloadString(
            //    String.Format(api,
            //    HttpUtility.UrlEncode(StorefrontToken),
            //    "",// HttpUtility.UrlEncode("State"), // State, example: AZ
            //    "", //HttpUtility.UrlEncode("City"), // City, example: Phoenix
            //    "5",   //  zoomlevel
            //    "yes",   //  showmap
            //    "",   //  techemail
            //    "yes",   //  mapscrollwheel
            //    "",   //  fblike
            //    "",   //  fbcomment
            //    HttpUtility.UrlEncode(Request.UserAgent), //user agent
            //    "", // count
            //    39.8283459, //lat
            //    -98.5816684, //long
            //    "nationwide",
            //    "yes", // cluster
            //    "no" // show minimap
            //    )
            //);

            var html = wc.DownloadString(
                String.Format(api,
                HttpUtility.UrlEncode(StorefrontToken),
                "TX",// HttpUtility.UrlEncode("State"), // State, example: AZ
                "", //HttpUtility.UrlEncode("City"), // City, example: Phoenix
                "5",   //  zoomlevel
                "yes",   //  showmap
                "",   //  techemail
                "yes",   //  mapscrollwheel
                "",   //  fblike
                "",   //  fbcomment
                HttpUtility.UrlEncode(Request.UserAgent), //user agent
                "", // count
                35.6039008, //lat
                -114.2028128, //long
                "regional",
                "yes", // cluster
                "no", // show minimap
                "2000" // Review Pin Map
                )
            );

            NearbyNowLiteral.Text = html;
        }
    }
}