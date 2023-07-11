namespace Assignment_3_PT2_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Customers}/{action=Show}/{id?}"
                );
            app.MapControllerRoute(
               name: "submitQuiz",
               pattern: "/Reset",
               defaults: new { controller = "Customers", action = "Reset" }
           );
            app.MapControllerRoute(
               name: "FilterByName",
               pattern: "/FilterByName",
               defaults: new { controller = "Customers", action = "FilterByName" }
           );
            app.MapControllerRoute(
               name: "FilterByName",
               pattern: "/FilterByGender",
               defaults: new { controller = "Customers", action = "FilterByGender" }
           );
            app.MapControllerRoute(
               name: "FilterByName",
               pattern: "/FilterByAddress",
               defaults: new { controller = "Customers", action = "FilterByAddress" }
           );
            app.Run();
        }
    }
}