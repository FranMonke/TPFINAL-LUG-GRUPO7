using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class LibroBusiness
    {

        private LibroDAO librosDao = new LibroDAO();

        public void EliminarLibro(int idlibro)
        {
            try
            {
                using (TransactionScope txr = new TransactionScope())
                {
                    Libro libro = librosDao.TraerLibroPorId(idlibro);
                    librosDao.EliminarLibroById(idlibro);
                    txr.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void GuardarListaLibros(List<Libro> librosLista)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (var lib in librosLista)
                    {
                        CargarLibro(lib);
                    }
                    trx.Complete();
                }

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
                using (TransactionScope trx = new TransactionScope())
                {
                    librosDao.CargarLibro(libro);
                    trx.Complete();
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
                return librosDao.GetLibrosAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AumentarStock(int idlibro, int nuevostock)
        {
            try
            {
                Libro libro = librosDao.TraerLibroPorId(idlibro);
                using (TransactionScope trx = new TransactionScope())
                {
                    librosDao.AumentarStock(libro, nuevostock);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DisminuirStock(int idlibro, int nuevostock)
        {
            try
            {
                Libro libro = librosDao.TraerLibroPorId(idlibro);
                using (TransactionScope trx = new TransactionScope())
                {
                    librosDao.DisminuirStock(libro, nuevostock);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
