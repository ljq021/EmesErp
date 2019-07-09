using System;
using Emes.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Emes.Core.Extensions.EF
{
    public static class EFConfigurationProviderExtension
    {
        public static void AddEmesDbContext(this IServiceCollection services, Action<DbContextOptionsBuilder> setup)
        {
            services.AddDbContextPool<EmesDbContext>(setup);
        }
    }
}
