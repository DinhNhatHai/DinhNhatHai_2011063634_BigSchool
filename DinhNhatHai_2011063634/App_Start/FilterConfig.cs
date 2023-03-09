using System.Web;
using System.Web.Mvc;

namespace DinhNhatHai_2011063634
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
