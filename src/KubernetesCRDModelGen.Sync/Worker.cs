using KubernetesCRDModelGen.Sync.CRD;

namespace KubernetesCRDModelGen.Sync;

internal class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    private readonly IConfiguration configuration;

    private readonly IHostApplicationLifetime _lifeTime;

    private readonly CRDDownloader _CRDDownloader;

    public Worker(ILogger<Worker> logger, IConfiguration configuration, IHostApplicationLifetime lifeTime, CRDDownloader cRDDownloader)
    {
        _logger = logger;
        this.configuration = configuration;
        _lifeTime = lifeTime;
        this._CRDDownloader = cRDDownloader;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            var rootDirectory = configuration.GetValue<string>("RootDirectory");

            _logger.LogInformation("Root Directory: {dir}", rootDirectory);

            var configs = configuration.GetSection("Config").Get<List<Config>>();

            ProjectGenerator.UpdateRootReadmePackageList(configs, rootDirectory);

            foreach (var item in configs)
            {
                _logger.LogInformation("Processing: {group}", item.Group);

                ProjectGenerator.GenerateProject(item.Group, rootDirectory);

                try
                {
                    if (item.DirectUrl != null && item.DirectUrl.Length > 0)
                    {
                        foreach (var directUrl in item.DirectUrl)
                        {
                            await _CRDDownloader.ProcessDirectUrl(directUrl, item.Group);
                        }
                    }
                    if (item.GitHub != null && item.GitHub.Length > 0)
                    {
                        foreach (var github in item.GitHub)
                        {
                            await _CRDDownloader.ProcessGitHub(github, item.Group);
                        }
                    }
                    if (item.Helm != null && item.Helm.Length > 0)
                    {
                        foreach (var helm in item.Helm)
                        {
                            await _CRDDownloader.ProcessHelmChart(helm, item.Group);
                        }
                    }
                    if (item.OCI != null && item.OCI.Length > 0)
                    {
                        foreach (var oci in item.OCI)
                        {
                            await _CRDDownloader.ProcessOCI(oci, item.Group);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Run Failed: {name}", item.Group);
                    throw;
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Run Failed");
            Environment.ExitCode = 1;
        }

        _lifeTime.StopApplication();
    }
}
