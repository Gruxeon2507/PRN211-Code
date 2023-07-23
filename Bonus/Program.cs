namespace Bonus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{Controller=View}/{Action=Index}/{id?}"
                );

            app.Run();
        }
    }
}