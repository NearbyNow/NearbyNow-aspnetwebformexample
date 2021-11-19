using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NearbyNowWebFormsExample
{
    public partial class CityPageTwo : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException("You need to supply the city/state params below then remove this exception");

            string myApi = "http://localhost:50899/plugin/nationwideserviceareareviewcombo?storefronttoken={0}&state={1}&city={2}&zoomlevel={3}&showmap={4}&techemail={5}&mapscrollwheel={6}&fblike={7}&fbcomment={8}&agent={9}&checkincount={10}";

            var wc = new WebClient();

            var fullUrl = String.Format(myApi,
                HttpUtility.UrlEncode(StorefrontToken),
                HttpUtility.UrlEncode("CA"), // State, example: AZ
                HttpUtility.UrlEncode("Indigo"), // City, example: Phoenix
                "9",   //  zoomlevel
                "yes",   //  showmap
                "",   //  techemail
                "yes",   //  mapscrollwheel
                "",   //  fblike
                "",   //  fbcomment
                HttpUtility.UrlEncode(Request.UserAgent), //user agent
                "" // count
                );

            var html = wc.DownloadString(
                fullUrl
            );

            NearbyNowLiteral.Text = html;
        }
    }
}