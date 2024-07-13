using System;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica 1 "Sistema de Gestion para Biblioteca" por Conrado Quezada
            Console.Write("Ingrese el nombre del bibliotecario: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el ID del bibliotecario: ");
            string idUsuario = Console.ReadLine();
            Bibliotecario bibliotecario = new Bibliotecario(nombre, idUsuario);

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Eliminar Cliente");
                Console.WriteLine("3. Agregar Libro");
                Console.WriteLine("4. Eliminar Libro");
                Console.WriteLine("5. Prestar Libro");
                Console.WriteLine("6. Devolver Libro");
                Console.WriteLine("7. Lista de Clientes");
                Console.WriteLine("8. Lista de Libros");
                Console.WriteLine("9. Lista de Prestamos");
                Console.WriteLine("10. Lista de Libros por Cliente");
                Console.WriteLine("11. Salir");
                Console.Write("Seleccione una opción: ");
                Console.WriteLine();
                string opcion = Console.ReadLine();
                Console.WriteLine("----------------------");


                switch (opcion)
                {
                    case "1":
                        Metodos.RegistrarCliente(bibliotecario);
                        break;
                    case "2":
                        Metodos.EliminarCliente(bibliotecario);
                        break;
                    case "3":
                        Metodos.AgregarLibro(bibliotecario);
                        break;
                    case "4":
                        Metodos.EliminarLibro(bibliotecario);
                        break;
                    case "5":
                        Metodos.PrestarLibro();
                        break;
                    case "6":
                        Metodos.DevolverLibro();
                        break;
                    case "7":
                        Metodos.ListaClientes();
                        break;
                    case "8":
                        Metodos.ListaLibros();
                        break;
                    case "9":
                        Metodos.ListaPrestamos();
                        break;
                    case "10":
                        Metodos.LibrosPrestadosPorCliente();
                        break;
                    case "11":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
