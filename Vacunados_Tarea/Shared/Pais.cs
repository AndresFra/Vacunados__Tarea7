using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class Pais
    {
        public Pais()
        {
            Provincias = new HashSet<Provincias>();
        }

      
        public int id { get; set; }
        public string nombre { get; set; }

       
        public virtual ICollection<Provincias> Provincias { get; set; }
    }
}
