using System;

namespace Practica1
{
    public class Libro
    {
        //Esta clase solo representa los parametros de la clase Libro
        public string titulo { get; set; }
        public string autor { get; set; }
        public string categoria { get; set; }
        public string isbn { get; set; }
        public string estado { get; set; }
        public Libro(string titulo, string autor, string categoria, string isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.isbn = isbn;
            this.estado = "Disponible";
        }

        public string Titulo => titulo;
        public string Autor => autor;
        public string Isbn => isbn;
        public string Estado => estado;

        public void DefinirEstado(string estado)
        {
            if (estado == "Disponible" || estado == "Prestado")
            {
                this.estado = estado;
            }
            else
            {
                throw new ArgumentException("Estado no válido");
            }
        }
    }
}
