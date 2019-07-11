using Autofac;
using Autofac.Extensions.DependencyInjection;
using Emes.Core.Extensions.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Surging.Core.CPlatform;
using Surging.Core.CPlatform.Utilities;
using Surging.Core.EventBusRabbitMQ.Configurations;

namespace Emes.Erp.Host
{
    public class Startup
    {
        public Startup(IConfigurationBuilder config)
        {
            ConfigureEventBus(config);

        }

        public IContainer ConfigureServices(ContainerBuilder builder)
        {
            var services = new ServiceCollection();
            ConfigureLogging(services);
            ConfigureSql(services);
            builder.Populate(services);
            ServiceLocator.Current = builder.Build();
            return ServiceLocator.Current;
        }

        public void Configure(IContainer app)
        {

        }

        #region 私有方法
        /// <summary>
        /// 配置日志服务
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureLogging(IServiceCollection services)
        {
            services.AddLogging();
        }

        private static void ConfigureEventBus(IConfigurationBuilder build)
        {
            build
            .AddEventBusFile("Configs/eventBusSettings.json", optional: false);
        }

        private static void ConfigureSql(IServiceCollection services)
        {
            var con = AppConfig.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            services.AddEmesDbContext(options =>
                    options.UseSqlServer(con, b => b.MigrationsAssembly("Emes.Erp.Host"))
            );
        }


        #endregion

    }
}
