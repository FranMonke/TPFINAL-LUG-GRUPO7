﻿using DAL;
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
                    bool dniExiste = prestamoDAO.ExisteAlumno(prestamo.DniAlumno);

                    if (!dniExiste)
                        throw new Exception("El DNI ingresado no existe en el sistema.");


                    bool libroDisponible = prestamoDAO.HayStockDisponible(prestamo.IdLibro);

                    if (!libroDisponible)
                        throw new Exception("No hay stock disponible del libro seleccionado.");


                    int limiteLibros = 3;
                    int librosEnPrestamo = prestamoDAO.GetCantidadLibrosPrestados(prestamo.DniAlumno);

                    if (librosEnPrestamo >= limiteLibros)
                        throw new Exception($"El alumno con DNI {prestamo.DniAlumno} ya tiene el máximo de {limiteLibros} libros en préstamo.");

                    if (prestamoDAO.VerificarPrestamosVencidos(prestamo))
                        throw new Exception($"ADVERTENCIA: Hay préstamos vencidos que deben ser gestionados antes de realizar un nuevo préstamo.");

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
                    bool prestamoExiste = prestamoDAO.ExistePrestamo(prestamo.IdPrestamo);
                    if (!prestamoExiste)
                    {
                        throw new Exception("El préstamo no existe en el sistema.");
                    }
                    if (prestamoDAO.PrestamoYaDevuelto(prestamo.IdPrestamo))
                    {
                        throw new Exception("El libro ya ha sido devuelto.");
                    }

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
