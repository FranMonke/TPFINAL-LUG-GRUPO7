using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrestamoDAO
    {
        public List<Prestamo> ObtenerPrestamos()
        {
            try
            {
                List<Prestamo> prestamos = new List<Prestamo>();

                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT * FROM PRESTAMOS";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                             while (reader.Read())
                             {
                                Prestamo prestamo = PrestamoMapper.Map(reader);
                                prestamos.Add(prestamo);
                                  
                             }
                        }                       
                    }
                }
                return prestamos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
