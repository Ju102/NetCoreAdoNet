using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Models
{
    // helper = new HelperConfiguration();
    // helper.GetConfiguration();
    // helper.GetConnectionString("key");
    
    // No hace falta inicializar el objeto =>
    // HelperConfiguration.GetConfiguration();
    // HelperConfiguration.GetConnectionString("key");
    public class EmpleadosParametersOut
    {
        public List<string> Apellidos { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int NumeroPersonas { get; set; }

        public EmpleadosParametersOut()
        {
            this.Apellidos = new List<string>(); // 2º forma.
        }

    }
}
