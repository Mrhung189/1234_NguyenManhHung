using System.Web;
using System.Web.Mvc;

namespace _1234_NguyenManhHung
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
