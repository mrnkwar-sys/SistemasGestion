using Ejercicio02;

namespace Ejercicio02.Data;

public static class RepositoryPersonas
{
    public static readonly clsPersona[] Personas = new clsPersona[10]
    {
        new clsPersona ( "Laura", "García López", new DateTime(2007, 3, 15), 18 ),
        new clsPersona ( "Mario", "Sánchez Martín", new DateTime(2006, 7, 22), 19 ),
        new clsPersona ( "Lucía", "Fernández Ruiz", new DateTime(2007, 1, 9), 18 ),
        new clsPersona ( "Daniel", "Pérez Gómez", new DateTime(2006, 11, 30), 19 ),
        new clsPersona ( "Marta", "Navarro Díaz", new DateTime(2007, 5, 3), 18 ),
        new clsPersona ( "Alejandro", "Torres Moreno", new DateTime(2006, 9, 18), 19 ),
        new clsPersona ( "Sofía", "Romero Castillo", new DateTime(2007, 2, 27), 18 ),
        new clsPersona ( "Pablo", "Ortega Molina", new DateTime(2006, 12, 11), 19 ),
        new clsPersona ( "Elena", "Vázquez Santos", new DateTime(2007, 6, 8), 18 ),
        new clsPersona ( "Javier", "Iglesias Rubio", new DateTime(2006, 4, 25), 19 )
    };

}
