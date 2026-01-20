using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Helpers
{
    public class HelperConfiguration
    {
        // Tenemos varias opciones. Dependiendo del tipo de logica, podemos pensar de una forma u otra.
        // Queremos recuperar el objeto config.
        public static IConfigurationRoot GetConfiguration()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);

            IConfigurationRoot configuration = builder.Build();

            return configuration;
        }
    }
}
