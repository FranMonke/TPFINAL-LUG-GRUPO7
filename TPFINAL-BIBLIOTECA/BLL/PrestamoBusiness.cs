using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamoBusiness
    {

        public PrestamoDAO prestamoDAO = new PrestamoDAO();
        public List<Prestamo> ObtenerPrestamos()
        {
            try
            {
                return prestamoDAO.ObtenerPrestamos();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    } 
}
