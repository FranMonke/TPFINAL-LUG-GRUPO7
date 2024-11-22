using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdLibro { get; set; }
        public int DniAlumno { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
    }
}
