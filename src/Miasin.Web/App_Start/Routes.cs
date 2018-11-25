using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Miasin.Web
{
    public static class Routes
    {
        public static void ConfigureRoutes(this IRouteBuilder routes)
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}