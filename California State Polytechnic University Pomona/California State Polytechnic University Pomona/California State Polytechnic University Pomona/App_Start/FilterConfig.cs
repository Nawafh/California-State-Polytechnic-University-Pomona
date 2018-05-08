using System.Web;
using System.Web.Mvc;

namespace California_State_Polytechnic_University_Pomona
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
