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

        public bool ExisteAlumno(int dniAlumno)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Alumnos WHERE DNI_ALUMNO = @dni";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniAlumno);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("El DNI del alumno no existe en el sistema.", ex);
            }
        }

        public bool HayStockDisponible(int idLibro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT CANTIDAD_DISPONIBLE FROM Libros WHERE ID_LIBRO = @idLibro";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idLibro", idLibro);
                        int stock = (int)cmd.ExecuteScalar();
                        return stock > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No hay stock disponible del libro seleccionado.", ex);
            }
        }

        public bool ExistePrestamo(int idPrestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Prestamos WHERE ID_PRESTAMO = @idPrestamo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el ID del préstamo.", ex);
            }
        }

        public bool PrestamoYaDevuelto(int idPrestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT FECHA_DEVOLUCION FROM Prestamos WHERE ID_PRESTAMO = @idPrestamo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                        object resultado = cmd.ExecuteScalar();

                        return resultado != DBNull.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar si el préstamo ya fue devuelto: " + ex.Message);
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

                    string queryObtenerIdLibro = "SELECT ID_LIBRO FROM Prestamos WHERE ID_PRESTAMO = @idPrestamo";
                    using (SqlCommand cmdObtenerIdLibro = new SqlCommand(queryObtenerIdLibro, conn))
                    {
                        cmdObtenerIdLibro.Parameters.AddWithValue("@idPrestamo", prestamo.IdPrestamo);
                        prestamo.IdLibro = Convert.ToInt32(cmdObtenerIdLibro.ExecuteScalar());
                    }

                    string queryActualizarCantidad = "UPDATE Libros SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE + 1 WHERE ID_LIBRO = @idlibro";
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

        public int GetCantidadLibrosPrestados(int dniAlumno)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM PRESTAMOS WHERE DNI_ALUMNO = @dni AND (FECHA_DEVOLUCION IS NULL OR FECHA_DEVOLUCION = '')";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@dni", dniAlumno);

                        object resultado = command.ExecuteScalar();

                        return resultado != null ? Convert.ToInt32(resultado) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la cantidad de libros prestados.", ex);
            }
        }

        public bool VerificarPrestamosVencidos(Prestamo prestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM PRESTAMOS WHERE (FECHA_DEVOLUCION IS NULL OR FECHA_DEVOLUCION = '') " +
                                   "AND DATEDIFF(DAY, FECHA_PRESTAMO, GETDATE()) > 14 AND DNI_ALUMNO = @DNI";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@DNI", prestamo.DniAlumno);

                        int count = (int)comando.ExecuteScalar();

                        if (count > 0)
                            return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el libro existe.", ex);
            }
        }

    }
}