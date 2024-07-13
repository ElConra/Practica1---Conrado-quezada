using System;
using System.Collections.Generic;

namespace Practica1
{
    public class Prestamo
    {
        //Esta clase guarda todos los prestamos que se han realizado en general, sin ningun tipo de filtro
        private Libro libro;
        private Cliente cliente;
        private DateTime fechaPrestamo;
        private DateTime? fechaDevolucion;

        public static List<Prestamo> ListaPrestamos = new List<Prestamo>();
        public Prestamo(Libro libro, Cliente cliente, DateTime fechaPrestamo)
        {
            this.libro = libro;
            this.cliente = cliente;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = null;
            ListaPrestamos.Add(this);
        }

        public void RegistrarDevolucion(DateTime fecha)
        {
            fechaDevolucion = fecha;
        }
        //Simplemente hace una lista de todos los prestamos que se han hecho en todo el sistema.
        public static void ListadePrestamos()
        {
            if (ListaPrestamos.Count == 0)
            {
                Console.WriteLine("No hay prestamos realizados.");
            }
            else
            {
                Console.WriteLine("Lista de Prestamos:");
                foreach (var prestamo in ListaPrestamos)
                {
                    Console.WriteLine("Cliente: " + prestamo.cliente.Nombre + " Titulo: " + prestamo.libro.Titulo +
                        " FechaPrestado: " + prestamo.fechaPrestamo.ToString());
                }
            }
        }
    }
}
