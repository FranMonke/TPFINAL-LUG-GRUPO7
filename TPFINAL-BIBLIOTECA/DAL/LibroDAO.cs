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
        public void EliminarLibroById(int iDlibro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    connection.Open();
                    string query = "DELETE FROM LIBROS WHERE ID_LIBRO= @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", iDlibro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Libro TraerLibroPorId(int idlibro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConfigurations.getDbName()))
                {
                    con.Open();
                    string query = "SELECT ID_LIBRO,TITULO,AUTOR,GENERO,CANTIDAD_DISPONIBLE FROM LIBROS WHERE ID_LIBRO=@id";
                    using (SqlCommand comando = new SqlCommand(query, con))
                    {
                        comando.Parameters.AddWithValue("@id", idlibro);
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Libro libro = LibroMapper.Map(reader);

                                return libro;
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
        public void CargarLibro(Libro libro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConfigurations.getDbName()))
                {
                    con.Open();
                    string query = "INSERT INTO LIBROS(TITULO,AUTOR,GENERO,CANTIDAD_DISPONIBLE) VALUES(@titulo,@autor,@genero,@cantdispo)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@titulo", libro.TituloLibro);
                        command.Parameters.AddWithValue("@autor", libro.AutorLibro);
                        command.Parameters.AddWithValue("genero", libro.GeneroLibro);
                        command.Parameters.AddWithValue("@cantdispo", libro.StockLibro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Libro> GetLibrosAll()
        {
            try
            {
                List<Libro> libros = new List<Libro>();
                using (SqlConnection connection = new SqlConnection(DbConfigurations.getDbName()))
                {
                    connection.Open();
                    string query = "SELECT ID_LIBRO,TITULO,AUTOR,GENERO, CANTIDAD_DISPONIBLE FROM LIBROS";
                    using (SqlCommand comand = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = comand.ExecuteReader())
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
        public void AumentarStock(Libro libro, int nuevostock)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConfigurations.getDbName()))
                {
                    con.Open();
                    string query = "UPDATE LIBROS SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE + @nuevostock WHERE ID_LIBRO = @id";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@id", libro.IdLibro);
                        command.Parameters.AddWithValue("@nuevostock", nuevostock);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DisminuirStock(Libro libro, int nuevostock)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConfigurations.getDbName()))
                {
                    con.Open();
                    string query = "UPDATE LIBROS SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE - @nuevostock WHERE ID_LIBRO = @id";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@id", libro.IdLibro);
                        command.Parameters.AddWithValue("@nuevostock", nuevostock);
                        command.ExecuteNonQuery();
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
