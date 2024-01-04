using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using TGDD.Web.Components;
using TGDD.Web.Helpers;

//using TGDD.Web.Components.Account;
using TGDD.Web.Services;
using TGDD.Web.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddRedisOutputCache("cache");


//builder.AddRedisDistributedCache("cache");
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configure the HTTP request pipeline for this blazor app

string baseAddress = builder.Environment.IsDevelopment() ? "http://localhost:5282" : "https://tgddapi.ashybeach-12aeeffe.southeastasia.azurecontainerapps.io/";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5282") });

//Configure the HTTP request pipeline aspire for this blazor app

builder.Services.AddHttpClient<ProductServiceClient>(client => client.BaseAddress = new("http://tgddapi"));

// set up authorization
builder.Services.AddAuthorizationCore();


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

// Add ReturnUrl Sate
builder.Services.AddScoped<HistoryProductURL>();


var app = builder.Build();

//app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

// Add additional endpoints required by the Identity /Account Razor components.
//app.MapAdditionalIdentityEndpoints();
app.MapDefaultEndpoints();

app.UseStaticFiles();
app.UseRouting();



app.UseAntiforgery();

//app.UseOutputCache();



app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();
