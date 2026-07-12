using KubernetesCRDModelGen.Sync.CRD;
using Microsoft.Extensions.Options;

namespace KubernetesCRDModelGen.Sync;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        var rootDirectory = builder.Configuration.GetValue<string>("RootDirectory");

        builder.Configuration.AddJsonFile(Path.Combine(rootDirectory, "sources.json"), optional: false);

        builder.Services.AddSingleton<CRDDownloader>();
        builder.Services.AddHostedService<Worker>();
        builder.Services.AddHttpClient(Options.DefaultName).AddStandardResilienceHandler();

        var host = builder.Build();
        host.Run();
    }
}