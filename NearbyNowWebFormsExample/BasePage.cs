using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearbyNowWebFormsExample
{
    public class BasePage : System.Web.UI.Page
    {
        protected const string api = "https://api.sidebox.com/plugin/nearbyreviews?storefronttoken={0}&state={1}&city={2}&zoomlevel={3}&showmap={4}&techemail={5}&mapscrollwheel={6}&fblike={7}&fbcomment={8}&agent={9}&count={10}";
        protected const string StorefrontToken = "get this from the nearby now admin site";
    }
}