using KubernetesCRDModelGen.Sync.CRD;

namespace KubernetesCRDModelGen.Sync;

class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    private readonly IConfiguration configuration;

    private readonly IHostApplicationLifetime _lifeTime;

    private readonly CRDDownloader _CRDDownloader;
    private readonly IHostEnvironment _environment;

    public Worker(ILogger<Worker> logger, IConfiguration configuration, IHostApplicationLifetime lifeTime, IHostEnvironment environment, CRDDownloader cRDDownloader)
    {
        _logger = logger;
        this.configuration = configuration;
        _lifeTime = lifeTime;
        _environment = environment;
        this._CRDDownloader = cRDDownloader;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            var rootDirectory = _environment.ContentRootPath;

            var configs = configuration.GetSection("Config").Get<List<Config>>()!
                ?? throw new InvalidOperationException("Config section is required.");

            if (configuration.GetValue<object>("DocFXGenerator") != null)
            {
                DocFXGenerator.GenerateDocFx(configs, rootDirectory);
                _lifeTime.StopApplication();
                return;
            }

            stoppingToken.ThrowIfCancellationRequested();

            ProjectGenerator.UpdateRootReadmePackageList(configs, rootDirectory);

            foreach (var item in configs)
            {
                stoppingToken.ThrowIfCancellationRequested();

                _logger.LogInformation("Processing: {group}", item.Group);

                await ProjectGenerator.GenerateProjectAsync(item.Group, rootDirectory, stoppingToken);

                try
                {
                    if (item.DirectUrl != null && item.DirectUrl.Length > 0)
                    {
                        foreach (var directUrl in item.DirectUrl)
                        {
                            await _CRDDownloader.ProcessDirectUrlAsync(directUrl, item.Group, stoppingToken);
                        }
                    }
                    if (item.GitHub != null && item.GitHub.Length > 0)
                    {
                        foreach (var github in item.GitHub)
                        {
                            await _CRDDownloader.ProcessGitHubAsync(github, item.Group, stoppingToken);
                        }
                    }
                    if (item.Helm != null && item.Helm.Length > 0)
                    {
                        foreach (var helm in item.Helm)
                        {
                            await _CRDDownloader.ProcessHelmChartAsync(helm, item.Group, stoppingToken);
                        }
                    }
                    if (item.OCI != null && item.OCI.Length > 0)
                    {
                        foreach (var oci in item.OCI)
                        {
                            await _CRDDownloader.ProcessOCIAsync(oci, item.Group, stoppingToken);
                        }
                    }
                }
                catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Run Failed: {name}", item.Group);
                    throw;
                }
            }
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker cancellation requested.");
            Environment.ExitCode = 130;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Run Failed");
            Environment.ExitCode = 1;
        }

        _lifeTime.StopApplication();
    }
}
