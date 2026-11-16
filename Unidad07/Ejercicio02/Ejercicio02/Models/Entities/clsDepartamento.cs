namespace Ejercicio02.Models.Entities
{
    public class clsDepartamento
    {
        public int IdDepartamento { get; }
        public string NombreDepartamento { get; set; }

        public clsDepartamento(int idDepartamento, string nombreDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
        }
    }
}
