using System.Web;
using System.Web.Mvc;

namespace MCAP.Nova.UW.GetMinimumRate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
