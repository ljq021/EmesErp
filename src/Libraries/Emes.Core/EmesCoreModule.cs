using Autofac;
using Emes.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Surging.Core.CPlatform.Module;
using CPlatformAppConfig = Surging.Core.CPlatform.AppConfig;

namespace Emes.Core
{
    public  class EmesCoreModule: EnginePartModule
    {
        public override void Initialize(AppModuleContext context)
        {
            base.Initialize(context);
        }

        /// <summary>
        /// Inject dependent third-party components
        /// </summary>
        /// <param name="builder"></param>
        protected override void RegisterBuilder(ContainerBuilderWrapper builder)
        {
            base.RegisterBuilder(builder);
            var configAssembliesStr = CPlatformAppConfig.GetSection("EmesCore:Assemblies").Get<string>();
            if (!string.IsNullOrEmpty(configAssembliesStr))
            {
                AppConfig.AssembliesStrings = configAssembliesStr.Split(";");
            }
            //builder.RegisterType<EmesDbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<DefaultIdWorker>().As<IIdWorker>().InstancePerLifetimeScope();
            builder.Register(context => new EmesDbContext(context.Resolve<DbContextOptions<EmesDbContext>>()))
                .As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(RepositoryWithTypedId<,>)).As(typeof(IRepositoryWithTypedId<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();



        }
    }
}

