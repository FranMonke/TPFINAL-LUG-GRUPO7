using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LibroDAO
    {
        public List<Libro> ObtenerLibros()
        {
            try
            {
                List<Libro> libros = new List<Libro>();

                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT * FROM LIBROS";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Libro libro = LibroMapper.Map(reader);
                                libros.Add(libro);

                            }
                        }
                    }
                }
                return libros;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
