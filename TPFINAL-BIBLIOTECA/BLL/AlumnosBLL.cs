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
    public class AlumnosBLL
    {
        AlumnosDAO alumnosDao = new AlumnosDAO();

        public void CargarAlumnos(Alumnoss alumnos)
        {

            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    validaciones(alumnos);
                    //Todas las validaciones...
                    alumnos.FechaRegistro= DateTime.Now;
                    alumnosDao.CargarAlumnos(alumnos);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static void validaciones(Alumnoss alumnos)
        {
            if (alumnos.Dni.ToString().Length < 8)
            {
                throw new Exception("El DNI debe tener al menos 8 dígitos.");
            }
            if (alumnos.Telefono.Length < 8)
            {
                throw new Exception("El Telefono debe tener al menos 8 dígitos.");
            }
            if (!alumnos.Email.Contains("@"))
            {
                throw new Exception("El email debe contener un '@'.");
            }
            if (alumnos.NombreCompleto.Length <= 4)
            {
                throw new Exception("El nombre completo debe tener más de 4 caracteres.");
            }
        }

        public void CargarAlumnosMultiples(List<Alumnoss> alumnos)
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
                Alumnoss alumnos = alumnosDao.GetById(v);
                if (alumnos == null) throw new Exception("Alumno inexistente");
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

        public List<Alumnoss> GetAll()
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
