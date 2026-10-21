namespace Ejercicio02
{
    public class clsAlumno : clsPersona
    {
        public string Curso { get; set; } = string.Empty;
        public int NumeroExpediente { get; set; }

    
        public clsAlumno(string nombre, string apellidos, DateTime fechaNacimiento, int edad, string curso, int numExpediente): base(nombre, apellidos, fechaNacimiento, edad)
        {
            Curso = curso;
            NumeroExpediente = numExpediente;
        }
    }
}