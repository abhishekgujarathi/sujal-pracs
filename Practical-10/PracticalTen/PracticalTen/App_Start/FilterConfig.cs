using System.Web;
using System.Web.Mvc;
using PracticalTen.Filters;

namespace PracticalTen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
        }
    }
}
