using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

        public void CargarPrestamo(Prestamo prestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();

                    string query = "INSERT INTO Prestamos(ID_LIBRO,DNI_ALUMNO,FECHA_PRESTAMO) VALUES(@idlibro,@dnialumno,@fechaprestamo)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idlibro", prestamo.IdLibro);
                        cmd.Parameters.AddWithValue("@dnialumno", prestamo.DniAlumno);
                        cmd.Parameters.AddWithValue("@fechaprestamo", prestamo.FechaPrestamo);
                        cmd.ExecuteNonQuery();

                    }
                    string queryActualizarCantidad = "UPDATE Libros SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE - 1 WHERE ID_LIBRO = @idlibro";
                    using (SqlCommand cmdActualizarCantidad = new SqlCommand(queryActualizarCantidad, conn))
                    {
                        cmdActualizarCantidad.Parameters.AddWithValue("@idlibro", prestamo.IdLibro);
                        cmdActualizarCantidad.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarDevolucion(Prestamo prestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();

                    string query = "UPDATE Prestamos SET FECHA_DEVOLUCION = @fechaDevolucion WHERE ID_PRESTAMO = @idPrestamo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPrestamo", prestamo.IdPrestamo);
                        cmd.Parameters.AddWithValue("@fechaDevolucion", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
