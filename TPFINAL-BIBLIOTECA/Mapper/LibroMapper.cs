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
                Titulo = reader["TITULO"].ToString(),
                Autor = reader["AUTOR"].ToString(),
                Genero = reader["GENERO"].ToString(),
                CantidadDisponible = Convert.ToInt32(reader["CANTIDAD_DISPONIBLE"].ToString())
            };
            return libro;
        }
    }
}
