using System;
using Emes.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Emes.Erp.System.Models
{
    public class SystemCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //SeedData(modelBuilder);
        }

        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
             new User()
             {
                 Id = 12356,
                 TenantId =0,
                 Version=1,
                 Name = "admin",
                 Password = "123456",
                 IsSystemAccount = true,
                 SystemName = "Admin",
                 IsLock = false,
                 EffectiveDate = new DateTimeOffset(),
                 IsLimitDuplicateLogin = false,
                 Notes = "超管",
                 CreatedById=0,
                 UpdatedById=0,
                 CreatedOn=new DateTimeOffset(),
                 UpdatedOn=new DateTimeOffset()
                 
             }
          );
        }
    }
}
