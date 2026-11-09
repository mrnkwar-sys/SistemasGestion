namespace Ejercicio02.Models.Entities
{
    public class clsPersona
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public clsPersona(int id, string nombre, String apellidos)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}
