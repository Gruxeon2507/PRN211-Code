var builder = WebApplication.CreateBuilder(args);

//Add: Chay xuat phat tu controller, goi den Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name:"default",
    pattern:"{Controller=Student}/{Action=show}/{id?}"
    );

app.Run();
