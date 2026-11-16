using Ejercicio02.Models.Entities;

namespace Ejercicio02.Models.Data.Repositories
{
    public class RepositoryPersona
    {
        public static List<clsPersona> getListadoPersonas()
        {
            List<clsPersona> listaPersonas = new List<clsPersona>
            {
                new clsPersona(1, "Raquel", "Nkwar", 1),
                new clsPersona(2, "Juan", "Pérez", 2),
                new clsPersona(3, "María", "García", 3),
                new clsPersona(4, "Pedro", "López", 4),
                new clsPersona(5, "Ana", "Martínez", 5)
            };

            return listaPersonas;
        }
    }
}
