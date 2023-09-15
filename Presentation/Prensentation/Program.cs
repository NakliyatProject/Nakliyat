using Persistence;
using Prensentation.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices();

builder.Services.AddControllersWithViews();

builder.Services.ConfigureIdentity();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Customer",
        areaName: "Customer",
        pattern: "Customer/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapAreaControllerRoute(
        name: "Company",
        areaName: "Company",
        pattern: "Company/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

});

app.ConfigureAndCheckMigration();

app.ConfigureLocalization();

app.ConfigureDefaultAdminUser();

app.Run();