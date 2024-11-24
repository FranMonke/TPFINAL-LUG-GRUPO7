using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class AlumnoBusiness
    {
        AlumnoDAO alumnosDao = new AlumnoDAO();

        public void CargarAlumnos(Alumno alumno)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope(TransactionScopeOption.Required))
                {
                    validaciones(alumno);
                    alumno.FechaRegistro = DateTime.Now;

                    if (alumnosDao.ExisteDni(alumno.Dni))
                    {
                        throw new Exception("Ya hay un alumno registrado con el mismo número de DNI. Intente ingresando otro número.");
                    }

                    if (alumnosDao.ExisteEmail(alumno.Email))
                    {
                        throw new Exception("Ya hay un alumno registrado con el mismo email. Intente ingresando otro email.");
                    }

                    alumnosDao.CargarAlumnos(alumno);
                    trx.Complete(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar alumno", ex);
            }
        }

        private static void validaciones(Alumno alumnos)
        {
            if (alumnos.Dni.ToString().Length < 8)
            {
                throw new Exception("El DNI debe tener 8 dígitos.");
            }
            if (alumnos.NombreCompleto.Length <= 4)
            {
                throw new Exception("El nombre completo debe tener más de 4 caracteres.");
            }
            if (alumnos.Telefono.Length < 8)
            {
                throw new Exception("El Telefono debe tener al menos 8 dígitos.");
            }
            if (!alumnos.Email.Contains("@"))
            {
                throw new Exception("El email debe contener un '@'.");
            }
        }

        public void CargarAlumnosMultiples(List<Alumno> alumnos)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (var app in alumnos)
                    {
                        CargarAlumnos(app);
                    }
                    trx.Complete();
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
                Alumno alumnos = alumnosDao.GetById(v);
                if (alumnos == null) throw new Exception("No hay ningún alumno con el númmero de DNI ingresado. Intente nuevamente.");
                using (TransactionScope trx = new TransactionScope())
                {

                    alumnosDao.DeleteById(v);
                    trx.Complete();
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
                return alumnosDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
