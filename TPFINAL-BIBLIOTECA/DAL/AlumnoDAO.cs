using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class AlumnoDAO
    {
        public void CargarAlumnos(Alumno alumnos)
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

        public List<Alumno> GetAll()
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
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
                                alumnos.Add(AlumnoMapper.Map(reader));
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

        public Alumno GetById(int dni)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conection.Open();
                    string query = "Select DNI_ALUMNO ,NOMBRE_COMPLETO, DIRECCION, TELEFONO, EMAIL,FECHA_REGISTRO FROM ALUMNOS WHERE DNI_ALUMNO = @DNI";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DNI", dni);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return AlumnoMapper.Map(reader);
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

        public bool ExisteEmail(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    connection.Open();

                    string query = "SELECT 1 FROM ALUMNOS WHERE EMAIL = @EMAIL";

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@EMAIL", email);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                                return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ExisteDni(int dni)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    conection.Open();

                    string query = "SELECT 1 FROM ALUMNOS WHERE DNI_ALUMNO = @DNI";

                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@DNI", dni);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                                return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
