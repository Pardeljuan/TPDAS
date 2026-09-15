using Microsoft.VisualBasic.FileIO;

namespace Domain.Entities
{
    public sealed class Alumno
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Edad { get; private set; }

        private readonly List<string> _materiasInscriptas = new List<string>();

        private Alumno() { }

        public Alumno(string nombre, string apellido, int edad)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException(nameof(nombre), "El nombre no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentNullException(nameof(apellido), "El apellido no puede estar vacío.");
            }
            if (edad < 17)
            {
                throw new ArgumentOutOfRangeException(nameof(edad), "La edad debe mayor o igual a 17" );
            }

            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;


        }
  
    }
}
