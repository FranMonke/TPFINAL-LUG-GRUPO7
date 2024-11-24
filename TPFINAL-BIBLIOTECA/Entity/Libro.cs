using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string TituloLibro { get; set; }
        public string AutorLibro { get; set; }
        public string GeneroLibro { get; set; }
        public int StockLibro { get; set; }
    }
}
