using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using LAInfrastructure.Data;
using System.Linq;
using LACore.Model;

namespace LAInfrastructure.Common
{
    internal class EFConfigProvider : ConfigurationProvider

    {
        private readonly Action<DbContextOptionsBuilder> _optionsAction;
        public EFConfigProvider(Action<DbContextOptionsBuilder> optionsAction)
        {
            _optionsAction = optionsAction;
        }
       public override void Load()
        {
            var builder = new DbContextOptionsBuilder<LOTTODBContext>();
            _optionsAction(builder);

            using (var dbContext = new LOTTODBContext(builder.Options))
            {
                dbContext.Database.EnsureCreated();
                Data = !dbContext.Configuration.Any()
                    ? CreateAndSaveDefaultValues(dbContext)
                    : dbContext.Configuration.ToDictionary(c => c.KeyName, c => c.KeyValue);
            }

        }
        private static IDictionary<string, string> CreateAndSaveDefaultValues(LOTTODBContext dbContext)
        {
            var configValues = new Dictionary<string, string>
                {
                    { "key1", "value_from_ef_1" },
                    { "key2", "value_from_ef_2" }
                };
            dbContext.Configuration.AddRange(configValues
                .Select(kvp => new Configuration { KeyName = kvp.Key, KeyValue = kvp.Value })
                .ToArray());
            dbContext.SaveChanges();
            return configValues;
        }



    }
}