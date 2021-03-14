using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class Vacunas
    {
        public Vacunas()
        {
            Personas = new HashSet<Personas>();
        }

       
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public long cantidad { get; set; }
        public bool disponibilidad { get; set; }

        public int? primeradosis_id { get; set; }

        public virtual PrimeraDosis PrimeraDosis { get; set; }

        public int? segundadosis_id { get; set; }

      
        public virtual SegundaDosis SegundaDosis { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
