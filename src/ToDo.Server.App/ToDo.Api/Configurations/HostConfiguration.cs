namespace ToDo.Api.Configurations;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder biBuilder)
    {
        biBuilder
            .AddValidators()
            .AddMappers()
            .AddPersistence()
            .AddCaching()
            .AddExposers()
            .AddCors()
            .AddDevTools();
        return new();
    }

    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app.UseCors();
        app.UseDevTools().UseExposers();
        return new();
    }
}