using Ejercicio02;

namespace Ejercicio02.Data;

public static class RepositoryAlumnos
{
    public static readonly clsAlumno[] Alumnos = new clsAlumno[3]
    {
        new clsAlumno ("Laura", "García López", new DateTime(2007, 3, 15), 18, "2º DAM", 2026001),
        new clsAlumno ("Mario", "Sánchez Martín", new DateTime(2006, 7, 22), 19, "1º DAM", 2026002 ),
        new clsAlumno ("Lucía", "Fernández Ruiz", new DateTime(2007, 1, 9), 18, "2º DAM", 2026003 ),
    };
}