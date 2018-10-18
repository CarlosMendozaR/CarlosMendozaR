
namespace ActividadColas
{
    class Alumno
    {
        private float calificacion;
        private string nombre;
        private bool aprovado;

        public float Calificacion { get => calificacion; set => calificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Aprovado { get => aprovado; set => aprovado = value; }

        public Alumno(float calificacion, string nombre, bool aprovado)
        {
            Calificacion = calificacion;
            Nombre = nombre;
            Aprovado = aprovado;
        }
    }
}
