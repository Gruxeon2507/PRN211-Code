namespace Assignment_3_PT2
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
                pattern: "{controller=Product}/{action=Show}/{id?}"
                );
            app.MapControllerRoute(
               name: "submitQuiz",
               pattern: "/Reset",
               defaults: new { controller = "Product", action = "Reset" }
           );
            app.MapControllerRoute(
               name: "submitQuiz",
               pattern: "/Update",
               defaults: new { controller = "Product", action = "Update" }
           );
            app.MapControllerRoute(
               name: "FilterByName",
               pattern: "/FilterByName",
               defaults: new { controller = "Product", action = "FilterByName" }
           ); 
                app.MapControllerRoute(
               name: "FilterByPrice",
               pattern: "/FilterByPrice",
               defaults: new { controller = "Product", action = "FilterByPrice" }
           ); 
                 app.MapControllerRoute(
               name: "FilterByImage",
               pattern: "/FilterByImage",
               defaults: new { controller = "Product", action = "FilterByImage" }
           );
            app.Run();
        }
    }
}