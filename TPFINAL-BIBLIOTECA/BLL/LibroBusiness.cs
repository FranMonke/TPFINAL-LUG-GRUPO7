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

        public LibroDAO libroDAO = new LibroDAO();
        public List<Libro> ObtenerLibros()
        {
            try
            {
                return libroDAO.ObtenerLibros();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
