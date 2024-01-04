using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;
using TGDD.Api.Data;
using TGDD.Api.Repositories;
using TGDD.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

//builder.AddRedis("cache");
builder.AddRedisDistributedCache("cache");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Serilog service

//ctx : context, lc : log configuration
builder.Host.UseSerilog((ctx, lc) =>
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration)
);

//Setting SQL Connection
builder.Services.AddDbContextPool<ShopOnlineDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

//Add Identity service require Login
//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ShopOnlineDbContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ShopOnlineDbContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["JwtIssuer"],
            ValidAudience = builder.Configuration["JwtAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSecurityKey"]))
        };
    });

// configure authorization
//builder.Services.AddAuthorization();

// add identity and opt-in to endpoints
//builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
//    .AddEntityFrameworkStores<ShopOnlineDbContext>();

//Add Repository Service
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();


// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});




var app = builder.Build();

app.MapDefaultEndpoints();


app.UseSwagger();
app.UseSwaggerUI();
app.MapSwagger().RequireAuthorization();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//    app.MapSwagger().RequireAuthorization();
//}

// Allow CORS policy

//app.UseCors(policy =>
//    policy.WithOrigins("http://localhost:7089", "https://localhost:7089")
//    .AllowAnyMethod()
//    .WithHeaders(HeaderNames.ContentType)
//);

app.UseSerilogRequestLogging();

// Use CORS policy
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

// create routes for the identity endpoints
app.MapIdentityApi<IdentityUser>();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
