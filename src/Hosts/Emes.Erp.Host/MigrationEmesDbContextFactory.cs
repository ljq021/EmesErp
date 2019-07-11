using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Emes.Core.Data;
using Emes.Core.Extensions.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Surging.Core.Caching.Configurations;
using Surging.Core.CPlatform;
using Surging.Core.CPlatform.Configurations;
using Surging.Core.CPlatform.Utilities;
using Surging.Core.ProxyGenerator;
using Surging.Core.ServiceHosting;
using Surging.Core.ServiceHosting.Internal.Implementation;

namespace Emes.Erp.Host
{
    public class MigrationEmesDbContextFactory : IDesignTimeDbContextFactory<EmesDbContext>
    {
        public EmesDbContext CreateDbContext(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var host = new ServiceHostBuilder()
                .RegisterServices(builder =>
                {
                    builder.AddMicroService(option =>
                    {
                        option.AddServiceRuntime()
                        .AddRelateService()
                        .AddConfigurationWatch()
                        //option.UseZooKeeperManager(new ConfigInfo("127.0.0.1:2181")); 
                        .AddServiceEngine(typeof(SurgingServiceEngine));
                        builder.Register(p => new CPlatformContainer(ServiceLocator.Current));
                    });
                })
                .ConfigureLogging(logger =>
                {
                    logger.AddConfiguration(
                        AppConfig.GetSection("Logging"));
                })
                .UseServer(options => { })
                .UseConsoleLifetime()
                .Configure(build =>
                build.AddCacheFile("${cachepath}|Configs/cacheSettings.json", basePath: AppContext.BaseDirectory, optional: false, reloadOnChange: true))
                  .Configure(build =>
                build.AddCPlatformFile("${surgingpath}|Configs/surgingSettings.json", optional: false, reloadOnChange: true))
                .UseStartup<Startup>()
                .Build();

            return ServiceLocator.GetService<EmesDbContext>();
        }
    }
}
