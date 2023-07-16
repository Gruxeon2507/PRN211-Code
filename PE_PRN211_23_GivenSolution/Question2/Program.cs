var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
                name: "orders",
                pattern: "/Orders/ListByCustomer",
                defaults: new { controller = "Order", action = "Order" }
               );
app.MapControllerRoute(
                name: "Statistic",
                pattern: "/Orders/ListByCustomer/{CustomerId}",
                defaults: new { controller = "Order", action = "Filter" }
            );
app.MapControllerRoute(
                name: "Statistic",
                pattern: "/Orders/Details/{id}",
                defaults: new { controller = "Order", action = "Detail" }
            );
app.MapGet("/", context =>
{
    context.Response.Redirect("/Orders/ListByCustomer");
    return Task.CompletedTask;

});
app.Run();
