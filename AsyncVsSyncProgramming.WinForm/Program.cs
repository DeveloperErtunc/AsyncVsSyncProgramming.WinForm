namespace AsyncVsSyncProgramming.WinForm;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        ApplicationConfiguration.Initialize();
        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddHttpClient(StringConstants.CountriesSnow, c =>
                {
                    c.BaseAddress = new Uri(StringConstants.CountriesSnowBaseAPI);
                });
                services.AddSingleton<IReadService, ReadService>();
                services.AddSingleton<ISnowService, SnowService>();
                services.AddTransient<Form1>();
            });
    }
}