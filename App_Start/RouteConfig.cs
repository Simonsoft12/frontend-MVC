namespace FrontendMVC.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
