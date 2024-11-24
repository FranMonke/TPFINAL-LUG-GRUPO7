using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class LibroMapper
    {
        public static Libro Map(SqlDataReader reader)
        {
            Libro libro = new Libro
            {
                IdLibro = Convert.ToInt32(reader["ID_LIBRO"].ToString()),
                TituloLibro = reader["TITULO"].ToString(),
                AutorLibro = reader["AUTOR"].ToString(),
                GeneroLibro = reader["GENERO"].ToString(),
                StockLibro = Convert.ToInt32(reader["CANTIDAD_DISPONIBLE"]),
            };
            return libro;
        }
    }
}
