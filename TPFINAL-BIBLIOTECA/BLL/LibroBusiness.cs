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

                    if (libro == null)
                        throw new Exception("No hay ningún libro con el número de ID ingresado. Intente nuevamente.");

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
                validaciones(libro);

                if (librosDao.ExisteLibro(libro))
                {
                    throw new Exception("Ya hay un libro registrado con el mismo título y autor. Intente nuevamente.");
                }

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

        public void AumentarStock(int idLibro, int nuevoStock)
        {
            try
            {
                Libro libro = librosDao.TraerLibroPorId(idLibro);

                if (libro == null)
                    throw new Exception("No existe ningún libro con ese ID. Intente nuevamente.");

                using (TransactionScope trx = new TransactionScope())
                {
                    librosDao.AumentarStock(libro, nuevoStock);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DisminuirStock(int idLibro, int nuevoStock)
        {
            try
            {
                Libro libro = librosDao.TraerLibroPorId(idLibro);

                if (libro == null)
                    throw new Exception("No existe ningún libro con ese ID. Intente nuevamente.");

                using (TransactionScope trx = new TransactionScope())
                {
                    librosDao.DisminuirStock(libro, nuevoStock);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void validaciones(Libro libro)
        {
            if (libro.TituloLibro.Length < 1)
                throw new Exception("El nombre del libro debe tener más de 1 caracter.");

            if (libro.AutorLibro.Length <= 4)
                throw new Exception("El nombre del autor debe tener más de 4 caracteres.");

            if (libro.GeneroLibro.Length < 4)
                throw new Exception("El género debe tener más de 4 caracteres.");

            if (libro.StockLibro < 1)
                throw new Exception("La cantidad debe ser mínimo 1.");
        }
    }
}
