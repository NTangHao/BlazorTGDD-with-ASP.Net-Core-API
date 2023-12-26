using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using TGDD.Web.Components;
using TGDD.Web.Helpers;

//using TGDD.Web.Components.Account;
using TGDD.Web.Services;
using TGDD.Web.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configure the HTTP request pipeline for this blazor app

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5282") });

//Configure the HTTP request pipeline aspire for this blazor app

builder.Services.AddHttpClient<ProductServiceClient>(client => client.BaseAddress = new("http://tgddapi"));

//Add Authentication State

//builder.Services.AddCascadingAuthenticationState();
//builder.Services.AddScoped<IdentityUserAccessor>();
//builder.Services.AddScoped<IdentityRedirectManager>();
//builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// Add external method login like gg,fb and add cookies service 

//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultScheme = IdentityConstants.ApplicationScheme;
//    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
//})
//    .AddIdentityCookies();

//builder.Services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ShopOnlineDbContext>()
//    .AddSignInManager()
//    .AddDefaultTokenProviders();

//builder.Services.AddSingleton<IEmailSender<IdentityUser>, IdentityNoOpEmailSender>();

// Add Service API
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<ICartService, CartService>();

//AddLocalstorage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLocalStorageService>();

builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

// set up authorization
builder.Services.AddAuthorizationCore();
var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
//app.MapAdditionalIdentityEndpoints();

app.Run();
