using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAInfrastructure.Common
{
    public static class EFExtensions
    {
        public static IConfigurationBuilder AddEntityFrameworkConfig(
            this IConfigurationBuilder builder, Action<DbContextOptionsBuilder> setup)
        {
            return builder.Add(new EFConfigSource(setup));
        }

    }
}
