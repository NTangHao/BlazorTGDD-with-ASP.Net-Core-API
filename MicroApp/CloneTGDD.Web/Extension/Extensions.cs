namespace CloneTGDD.Web.Extension
{
    public static class Extensions
    {
        public static void AddApplicationServices(this IHostApplicationBuilder builder)
        {
            // HTTP client registrations     
              
            builder.Services.AddHttpClient<WeatherApiClient>(o => o.BaseAddress = new("http://productsapi"));
            builder.Services.AddHttpClient<ProductsApiClient>(o => o.BaseAddress = new("http://productsapi"));
        }
    }
}
