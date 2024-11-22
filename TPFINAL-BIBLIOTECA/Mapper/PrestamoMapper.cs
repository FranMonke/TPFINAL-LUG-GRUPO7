using System;
using Entity;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PrestamoMapper
    {
        public static Prestamo Map (SqlDataReader reader)
        {
            Prestamo prestamo = new Prestamo
            {
                IdPrestamo = Convert.ToInt32(reader["ID_PRESTAMO"].ToString()),
                IdLibro = Convert.ToInt32(reader["ID_LIBRO"].ToString()),
                DniAlumno = Convert.ToInt32(reader["DNI_ALUMNO"].ToString()),
                FechaPrestamo = Convert.ToDateTime(reader["FECHA_PRESTAMO"].ToString()),
                FechaDevolucion = reader["FECHA_DEVOLUCION"] == DBNull.Value
                          ? (DateTime?)null
                          : Convert.ToDateTime(reader["FECHA_DEVOLUCION"])
            };
            return prestamo;
        }
    }
}
