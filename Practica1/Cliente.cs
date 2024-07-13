using System;
using System.Collections.Generic;

namespace Practica1
{
    public class Cliente : Persona
    {
        //Se crea la clase Cliente heredando de Persona
        public static List<Libro> librosSolicitados;

        public Cliente(string nombre, string idUsuario) : base(nombre, idUsuario)
        {

            librosSolicitados = new List<Libro>();
        }
        //El Cliente puede solicitar un libro, por lo que se ingresa el parametro Libro lo que 
        //cambia el estado del libro a "Prestado" usando el metodo DefinirEstado de la clase libro
        public void SolicitarLibro(Libro libro)
        {
            if (libro.estado == "Disponible")
            {
                libro.DefinirEstado("Prestado");
                librosSolicitados.Add(libro);
            }
            else
            {
                throw new Exception("El libro no esta disponbile.");
            }
        }
        //El Cliente puede devolver un libro, por lo que se ingresa el parametro Libro lo que 
        //cambia el estado del libro a "Disponible" usando el metodo DefinirEstado de la clase libro
        public void DevolverLibro(Libro libro)
        {
            if (librosSolicitados.Contains(libro))
            {
                libro.DefinirEstado("Disponible");
                librosSolicitados.Remove(libro);
            }
            else
            {
                throw new Exception("El cliente no tiene este libro.");
            }
        }
        //Hace un recorrido de todos libros solicitados de un cliente
        public static void ListadeLibros()
        {
            if (librosSolicitados.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de Libros Solicitados:");
                foreach (var libro in librosSolicitados)
                {
                    Console.WriteLine("Título: " + libro.Titulo + " Autor: " + libro.Autor + " ISBN: " + libro.Isbn);
                }
            }
        }

    }
}
