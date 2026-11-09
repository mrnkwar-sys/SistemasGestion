using Ejercicio02.Models.Entities;

namespace Ejercicio02.Models.Data.Repositories
{
    public class RepositoryPersona
    {
        public static List<clsPersona> getListadoPersonas()
        {
            List<clsPersona> listaPersonas = new List<clsPersona>
            {
                new clsPersona(1, "Raquel", "Nkwar"),
                new clsPersona(2, "Juan", "Pérez"),
                new clsPersona(3, "María", "García"),
                new clsPersona(4, "Pedro", "López"),
                new clsPersona(5, "Ana", "Martínez")
            };

            return listaPersonas;
        }
    }
}
