using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class Provincias
    {
        public Provincias()
        {
            Personas = new HashSet<Personas>();
        }

    
        public int id { get; set; }
        public string nombre { get; set; }
        public int? pais_id { get; set; }

    
        public virtual Pais Pais { get; set; }
    
        public virtual ICollection<Personas> Personas { get; set; }
    }
}
