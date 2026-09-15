namespace Domain.Entities
{
    public sealed class Alumno
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Edad { get; private set; }

        private Alumno() { }

        public Alumno(string nombre, string apellido, int edad)
        {
            if(string .IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException("El nombre no puede estar vacío.", nameof(nombre));
            }
            if(string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentNullException("El apellido no puede estar vacío.", nameof(apellido));
            }
            if(edad <= 17)
            {
                throw new ArgumentOutOfRangeException("La edad debe mayor o igual a 17", nameof(edad));
            }

            Id = Guid.NewGuid();
       
        }
        public void InscripcionMateria

    }

}
