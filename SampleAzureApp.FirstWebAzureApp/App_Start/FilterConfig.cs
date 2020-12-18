using System.Web;
using System.Web.Mvc;

namespace SampleAzureApp.FirstWebAzureApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
