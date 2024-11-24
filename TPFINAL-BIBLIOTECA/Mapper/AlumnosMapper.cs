using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AlumnosMapper
    {
        public static Alumnoss Map(SqlDataReader reader)
        {
            Alumnoss alumnos = new Alumnoss();
            alumnos.Dni = reader.GetInt32(0);
            alumnos.NombreCompleto = reader.GetString(1);
            
            alumnos.Direccion= reader.GetString(2);
            alumnos.Telefono = reader.GetString(3);
            alumnos.Email = reader.GetString(4);
            alumnos.FechaRegistro= reader.GetDateTime(5);
            return alumnos;
            
        }
    }
}
