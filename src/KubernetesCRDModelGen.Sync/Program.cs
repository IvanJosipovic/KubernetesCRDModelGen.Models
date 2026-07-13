using KubernetesCRDModelGen.Sync.CRD;
using Microsoft.Extensions.Options;
using System.ComponentModel;

namespace KubernetesCRDModelGen.Sync;

[EditorBrowsable(EditorBrowsableState.Never)]
public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder.Configuration.AddJsonFile("sources.json", optional: false);

        builder.Services.AddSingleton<CRDDownloader>();
        builder.Services.AddHostedService<Worker>();
        builder.Services.AddHttpClient(Options.DefaultName).AddStandardResilienceHandler();

        var host = builder.Build();
        host.Run();
    }
}