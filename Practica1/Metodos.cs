using System;

namespace Practica1
{
    public class Metodos
    {
        //En este metodo el bibliotecario ingresa el nombre y idUsuario del nuevo cliente a registrar
        //Se utiliza el metodo RegistrarCliente de la clase Bibliotecario para hacer la validacion
        public static void RegistrarCliente(Bibliotecario bibliotecario)
        {

            Console.Write("Ingrese el nombre del lector: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el ID del lector: ");
            string idUsuario = Console.ReadLine();
            Cliente cliente = new Cliente(nombre, idUsuario);
            bibliotecario.RegistrarCliente(cliente);
        }
        //En este metodo el bibliotecario ingresa los parametros necesario del nuevo libro a registrar
        //Se utiliza el metodo IngresarLibro de la clase Bibliotecario para hacer la validacion
        public static void AgregarLibro(Bibliotecario bibliotecario)
        {
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese la categoria del libro: ");
            string categoria = Console.ReadLine();
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();
            Libro libro = new Libro(titulo, autor, categoria, isbn);
            bibliotecario.IngresarLibro(libro);
        }
        //En este metodo el bibliotecario ingresa los parametros necesario del libro a eliminar
        //Se utiliza el metodo EliminarLibro de la clase Bibliotecario para hacer la validacion
        public static void EliminarLibro(Bibliotecario bibliotecario)
        {
            Console.Write("Ingrese el ISBN del libro a eliminar: ");
            string isbn = Console.ReadLine();
            bibliotecario.EliminarLibro(isbn);
        }
        //En este metodo el bibliotecario ingresa los parametros necesario del cliente a eliminar
        //Se utiliza el metodo EliminarCliente de la clase Bibliotecario para hacer la validacion
        public static void EliminarCliente(Bibliotecario bibliotecario)
        {
            Console.Write("Ingrese el idUsuario del cliente a eliminar: ");
            string idUsuario = Console.ReadLine();
            bibliotecario.EliminarCliente(idUsuario);
        }

        public static void PrestarLibro()
        {
            Console.Write("Ingrese el ID del lector: ");
            string idUsuario = Console.ReadLine();
            Cliente cliente = Bibliotecario.ListaClientes.Find(l => l.IdUsuario == idUsuario);

            if (cliente == null)
            {
                Console.WriteLine("Lector no encontrado.");
                return;
            }

            Console.Write("Ingrese el ISBN del libro a prestar: ");
            string isbn = Console.ReadLine();
            Libro libro = Bibliotecario.ListaLibros.Find(l => l.Isbn == isbn);

            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            DateTime fecha = DateTime.Now;
            try
            {
                cliente.SolicitarLibro(libro);
                Prestamo prestamo = new Prestamo(libro, cliente, fecha);
                Console.WriteLine("El libro: " + libro.Titulo + " se presto a: " + cliente.IdUsuario + " el dia: " + fecha.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DevolverLibro()
        {
            Console.Write("Ingrese el ID del lector: ");
            string idUsuario = Console.ReadLine();
            Cliente cliente = Bibliotecario.ListaClientes.Find(l => l.IdUsuario == idUsuario);

            if (cliente == null)
            {
                Console.WriteLine("Lector no encontrado.");
                return;
            }

            Console.Write("Ingrese el ISBN del libro a devolver: ");
            string isbn = Console.ReadLine();
            Libro libro = Cliente.librosSolicitados.Find(l => l.Isbn == isbn);

            if (libro == null)
            {
                Console.WriteLine("El lector no tiene prestado ese libro.");
                return;
            }

            DateTime fechadevolucion = DateTime.Now;
            try
            {
                cliente.DevolverLibro(libro);
                Console.WriteLine("El libro: " + libro.Titulo + " se devolvio por: " + cliente.IdUsuario + " el dia: " + fechadevolucion.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void LibrosPrestadosPorCliente()
        {
            Console.Write("Ingrese el ID del lector: ");
            string idUsuario = Console.ReadLine();
            Cliente cliente = Bibliotecario.ListaClientes.Find(l => l.IdUsuario == idUsuario); 
            
            if (cliente == null) {
                Console.WriteLine("Cliente no existe");
            
            }
            Cliente.ListadeLibros();

        }
        public static void ListaClientes()
        {
            Bibliotecario.ListadeClientes();

        }

        public static void ListaLibros()
        {
            Bibliotecario.ListadeLibros();

        }
        public static void ListaPrestamos()
        {
            Prestamo.ListadePrestamos();

        }

    }
}
