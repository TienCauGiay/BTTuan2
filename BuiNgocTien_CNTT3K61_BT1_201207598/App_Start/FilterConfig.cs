using System.Web;
using System.Web.Mvc;

namespace BuiNgocTien_CNTT3K61_BT1_201207598
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
