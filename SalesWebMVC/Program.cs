
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using SalesWEBMvc.Services;
using SalesWEBMVC.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesWEBMVCContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("SalesWEBMVCContext"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("SalesWEBMVCContext")),
        mySqlOptions => mySqlOptions.MigrationsAssembly("SalesWEBMVC")));

// ?? throw new InvalidOperationException("Connection string 'SalesWEBMVCContext' not found.");
/* options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWEBMVCContext") ?? throw new InvalidOperationException("Connection string 'SalesWEBMVCContext' not found.")));*/

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();

var app = builder.Build();

var enUS = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUS),
    SupportedCultures = new List<CultureInfo> { enUS },
    SupportedUICultures = new List<CultureInfo> { enUS }
};

app.UseRequestLocalization(localizationOptions);    


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
