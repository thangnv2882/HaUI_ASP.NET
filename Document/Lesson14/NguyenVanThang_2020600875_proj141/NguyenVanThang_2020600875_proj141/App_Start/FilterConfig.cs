using System.Web;
using System.Web.Mvc;

namespace NguyenVanThang_2020600875_proj141
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
