using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class SignosSodiacales
    {
        public SignosSodiacales()
        {
            Personas = new HashSet<Personas>();
        }

      
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
