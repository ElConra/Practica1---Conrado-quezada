namespace Practica1
{
    public class Persona
    {
        //Esta clase solo crea la entidad persona con propiedad Nombre y IdUsuario.
        public string nombre { get; set; }
        public string idUsuario { get; set; }


        public Persona(string nombre, string idUsuario)
        {
            this.nombre = nombre;
            this.idUsuario = idUsuario;
        }

        public string Nombre => nombre;
        public string IdUsuario => idUsuario;
    }
}
