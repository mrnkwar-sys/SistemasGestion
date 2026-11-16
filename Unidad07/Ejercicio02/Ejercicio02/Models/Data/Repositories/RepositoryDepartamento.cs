using Ejercicio02.Models.Entities;

namespace Ejercicio02.Models.Data.Repositories
{
    public class RepositoryDepartamento
    {
        public static List<clsDepartamento> getListadoDepartamentos()
        {
            List<clsDepartamento> listaDepartamentos = new List<clsDepartamento>
            {
                new clsDepartamento(1, "Ventas"),
                new clsDepartamento(2, "Marketing"),
                new clsDepartamento(3, "Desarrollo"),
                new clsDepartamento(4, "Recursos Humanos"),
                new clsDepartamento(5, "Finanzas")
            };

            return listaDepartamentos;
        }
    }
}

          
