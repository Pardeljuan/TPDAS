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
                throw new ArgumentNullException("El nombre no puede estar vacío.", nameof(nombre));
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentNullException("El apellido no puede estar vacío.", nameof(apellido));
            }
            if (edad < 17)
            {
                throw new ArgumentOutOfRangeException("La edad debe mayor o igual a 17", nameof(edad));
            }

            Id = Guid.NewGuid();

        }
        public void AltaMateria(string materia)
        {
            if (string.IsNullOrWhiteSpace(materia))
            {
                throw new ArgumentNullException("La materia no puede estar vacía.", nameof(materia));
            }
            if (_materiasInscriptas.Contains(materia))
            {
                throw new InvalidOperationException($"El alumno ya está inscripto en la materia {materia}.");
            }

            if (_materiasInscriptas.Count >= 3)
            {
                throw new InvalidOperationException("El alumno no puede inscribirse en más de 3 materias.");
            }
            _materiasInscriptas.Add(materia);
        }
        public void BajaMateria(string materia)
        {
            if (string.IsNullOrWhiteSpace(materia))
            {
                throw new ArgumentNullException("La materia no puede estar vacía.", nameof(materia));
            }
            
        }
    }
}
