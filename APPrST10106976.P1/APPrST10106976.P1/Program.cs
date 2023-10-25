using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using APPrST10106976.P1.Data;
using APPrST10106976.P1.Areas.Identity.Data;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AplyrContextConnection") ?? throw new InvalidOperationException("Connection string 'AplyrContextConnection' not found.");

builder.Services.AddDbContext<AplyrContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<APPrEnjoyer>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<AplyrContext>();

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.Configure<IdentityOptions>(options =>
  // {
  //     Options.Password.RequireUppercase = false;
 //  });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
