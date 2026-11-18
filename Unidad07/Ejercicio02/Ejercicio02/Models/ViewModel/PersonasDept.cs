using Ejercicio02.Models.Entities;

namespace Ejercicio02.Models.ViewModel
{
    public class PersonasDept
    {
        public clsPersona Persona { get; set; }
        public List<clsDepartamento> Departamentos { get; }

        public PersonasDept(clsPersona persona, List<clsDepartamento> departamentos)
        {
            Persona = persona;
            Departamentos = departamentos;
        }
    }
}
