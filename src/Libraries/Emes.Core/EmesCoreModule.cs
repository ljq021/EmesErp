using Emes.Core.Data;
using Surging.Core.CPlatform.Module;
using System;
using System.Collections.Generic;
using System.Text;

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
            builder.RegisterType<DefaultIdWorker>().As<IIdWorker>().InstancePerLifetimeScope();
            builder.RegisterType<EmesDbContext>().As<IDbContext>().InstancePerLifetimeScope();

        }
    }
}

