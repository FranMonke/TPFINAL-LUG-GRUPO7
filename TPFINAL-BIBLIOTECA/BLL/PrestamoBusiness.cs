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

        public void CargarPrestamo(Prestamo prestamo)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    //validar que el dni exista en la BD
                    //validar que cantidad_disponible sea >0

                    prestamoDAO.CargarPrestamo(prestamo);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarDevolucion(Prestamo prestamo)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    //validar que el id del prestamo exista en la BD

                    prestamoDAO.CargarDevolucion(prestamo);
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
