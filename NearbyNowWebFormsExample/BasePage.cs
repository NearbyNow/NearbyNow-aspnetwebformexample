using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearbyNowWebFormsExample
{
    public class BasePage : System.Web.UI.Page
    {
        protected const string api = "http://localhost:50899/plugin/nationwideserviceareareviewcombo?storefronttoken={0}&state={1}&city={2}&zoomlevel={3}&showmap={4}&techemail={5}&mapscrollwheel={6}&fblike={7}&fbcomment={8}&agent={9}&count={10}&lat={11}&long={12}&mapsize={13}&cluster={14}&ShowMiniMap={15}&ReviewPinMax={16}";

        protected const string StorefrontToken = "f99c5f1f-9c96-49ab-99cc-3a916e1ccade";
    }
}