using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica1
{
    public class Bibliotecario : Persona
    {
        //Se crea la clase Bibliotecario heredando de Persona.
        public static List<Bibliotecario> ListaBibliotecarios = new List<Bibliotecario>();
        public static List<Cliente> ListaClientes = new List<Cliente>();
        public static List<Libro> ListaLibros = new List<Libro>();
        public Bibliotecario(string nombre, string idUsuario) : base(nombre, idUsuario)
        {

        }
        //El bibliotecario tiene permisos para Registrar Clientes nuevos creando un objeto llamado Cliente
        //si ya existe arroja un error.
        public void RegistrarCliente(Cliente cliente)
        {
            if (ListaClientes.Any(l => l.IdUsuario == cliente.IdUsuario))
            {
                throw new Exception("El cliente ya existe en el sistema");
            }
            else
            {
                ListaClientes.Add(cliente);
                Console.WriteLine("Cliente agregado exitosamente");
            }

        }
        //El bibliotecario tiene permisos para Eliminar Libros por medio de la parametro idUsuario.
        public void EliminarCliente(string idUsuario)
        {
            Cliente cliente = ListaClientes.Find(l => l.IdUsuario == idUsuario);
            if (cliente != null)
            {
                ListaClientes.Remove(cliente);
                Console.WriteLine("Cliente eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }
        //El bibliotecario tiene permisos para Registrar Libros nuevos creando un objeto llamado Libro
        //si ya existe arroja un error.
        public void IngresarLibro(Libro libro)
        {
            if (ListaLibros.Any(l => l.Isbn == libro.isbn))
            {
                throw new Exception("El libro ya existe en el sistema");
            }
            else
            {
                ListaLibros.Add(libro);
                Console.WriteLine("Libro agregado exitosamente");
            }


        }

        //El bibliotecario tiene permisos para Eliminar Libros por medio de la parametro isbn.
        public void EliminarLibro(string isbn)
        {
            Libro libro = ListaLibros.Find(l => l.Isbn == isbn);
            if (libro != null)
            {
                ListaLibros.Remove(libro);
                Console.WriteLine("Libro eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
        //Este metodo permite hacer un recorrido de todos los libros registrados.
        public static void ListadeLibros()
        {
            if (ListaLibros.Count == 0)
            {
                Console.WriteLine("No hay libros disponibles.");
            }
            else
            {
                Console.WriteLine("Lista de Libros:");
                foreach (var libro in ListaLibros)
                {
                    Console.WriteLine("Título: " + libro.Titulo + " Autor: " + libro.Autor + " ISBN: " + libro.Isbn + " Estado: " + libro.Estado);
                }
            }
        }

        //Este metodo permite hacer un recorrido de todos los clientes registrados.
        public static void ListadeClientes()
        {
            if (ListaClientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de Clientes:");
                foreach (var cliente in ListaClientes)
                {
                    Console.WriteLine("Nombre: " + cliente.Nombre + " ID: " + cliente.IdUsuario);
                }
            }
        }
    }
}
