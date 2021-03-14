using System;
using System.Collections.Generic;
using System.Text;

namespace Vacunados_Tarea.Shared
{
    public class SegundaDosis
    {
        public SegundaDosis()
        {
            Vacunas = new HashSet<Vacunas>();
        }

        public int id { get; set; }
        public bool recibida { get; set; }
        public DateTime fechaRecibida { get; set; }

       
        public virtual ICollection<Vacunas> Vacunas { get; set; }
    }
}
