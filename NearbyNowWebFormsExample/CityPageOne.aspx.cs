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

            string api2 = "http://localhost:50899/plugin/nearbyservicearea?storefronttoken={0}&state={1}&city={2}&zoomlevel={3}&showmap={4}&techemail={5}&mapscrollwheel={6}&fblike={7}&fbcomment={8}&agent={9}&count={10}";

            string api3 = "http://localhost:50899/plugin/photogallery?storefronttoken={0}";
            var wc = new WebClient();
            //var html = wc.DownloadString(
            //    String.Format(api2,
            //    HttpUtility.UrlEncode(StorefrontToken),
            //    HttpUtility.UrlEncode("TX"), // State, example: AZ
            //    HttpUtility.UrlEncode("Boerne"), // City, example: Phoenix
            //    "9",   //  zoomlevel
            //    "yes",   //  showmap
            //    "",   //  techemail
            //    "yes",   //  mapscrollwheel
            //    "",   //  fblike
            //    "",   //  fbcomment
            //    HttpUtility.UrlEncode(Request.UserAgent), //user agent
            //    "10" // count
            //    )
            //);

            //var URL = String.Format(api3,
            //    HttpUtility.UrlEncode(StorefrontToken),
            //    HttpUtility.UrlEncode("TX"), // State, example: AZ
            //    HttpUtility.UrlEncode("Boerne"));

            //var html = wc.DownloadString(
            //    String.Format(api3,
            //    HttpUtility.UrlEncode(StorefrontToken),
            //    HttpUtility.UrlEncode("TX"), // State, example: AZ
            //    HttpUtility.UrlEncode("Boerne")
            //    )
            //);

            var URL = String.Format(api3,
                HttpUtility.UrlEncode(StorefrontToken));

            var html = wc.DownloadString(
                String.Format(api3,
                HttpUtility.UrlEncode(StorefrontToken)
                )
            );

            NearbyNowLiteral.Text = html;
        }
    }
}