using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class AlumnosDAO
    {
        public void CargarAlumnos(Alumnoss alumnos)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conexion.Open();

                    string query = "INSERT INTO ALUMNOS(DNI_ALUMNO,NOMBRE_COMPLETO,DIRECCION,TELEFONO,EMAIL, FECHA_REGISTRO) VALUES(@dni,@nombrecompleto,@dirrecion,@telefono,@email,@fecha)";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@dni", alumnos.Dni);
                        command.Parameters.AddWithValue("@nombrecompleto", alumnos.NombreCompleto);
                        command.Parameters.AddWithValue("@dirrecion", alumnos.Direccion);
                        command.Parameters.AddWithValue("@telefono", alumnos.Telefono);
                        command.Parameters.AddWithValue("@email", alumnos.Email);
                        command.Parameters.AddWithValue("@fecha", alumnos.FechaRegistro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteById(int v)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conexion.Open();

                    string query = "DELETE FROM ALUMNOS WHERE DNI_ALUMNO = @DNI";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@DNI", v);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Alumnoss> GetAll()
        {
            try
            {
                List<Alumnoss> alumnos = new List<Alumnoss>();
                using (SqlConnection conection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conection.Open();
                    string query = "SELECT DNI_ALUMNO ,NOMBRE_COMPLETO, DIRECCION, TELEFONO, EMAIL,FECHA_REGISTRO FROM ALUMNOS";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                alumnos.Add(AlumnosMapper.Map(reader));
                            }
                        }
                    }
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Alumnoss GetById(int v)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conection.Open();
                    string query = "Select DNI_ALUMNO ,NOMBRE_COMPLETO, DIRECCION, TELEFONO, EMAIL,FECHA_REGISTRO FROM ALUMNOS WHERE DNI_ALUMNO = @DNI";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DNI", v);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return AlumnosMapper.Map(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
