using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Habitacion()
        {
        }

        public Habitacion(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
