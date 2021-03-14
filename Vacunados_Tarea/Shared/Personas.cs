using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class Personas
    {
       
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public int? vacuna_id { get; set; }

        public virtual Vacunas Vacunas { get; set; }

        public int? provincia_id { get; set; }

      
        public virtual Provincias Provincias { get; set; }

        public int? signosodiacal_id { get; set; }

        public virtual SignosSodiacales SignosSodiacales { get; set; }
    }
}
