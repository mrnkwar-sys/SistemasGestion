namespace Ejercicio02;

public class clsPersona
{
    public string Nombre { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public int Edad { get; set; }

    public clsPersona(string nombre, string apellidos, DateTime fechaNacimiento, int edad)
    {

        Nombre = nombre;
        Apellidos = apellidos;
        FechaNacimiento = fechaNacimiento;
        Edad = edad;
    }
}
