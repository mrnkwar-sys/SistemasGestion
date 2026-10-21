using Ejercicio02.Data;

Console.WriteLine("Listado de alumnos");
Console.WriteLine("==================");

foreach (var persona in RepositoryPersonas.Personas)
{
    Console.WriteLine($"{persona.Nombre} {persona.Apellidos}");
    Console.WriteLine($"Fecha de nacimiento: {persona.FechaNacimiento:d}");
    Console.WriteLine($"Edad: {persona.Edad}");
    Console.WriteLine();
}

Console.WriteLine("==================");
Console.WriteLine("ALUMNOS");
Console.WriteLine("==================");

foreach (var alumno in RepositoryAlumnos.Alumnos)
{
    Console.WriteLine($"Expediente: {alumno.NumeroExpediente}");
    Console.WriteLine($"Nombre: {alumno.Nombre} {alumno.Apellidos}");
    Console.WriteLine($"Curso: {alumno.Curso}");
    Console.WriteLine("------------------------------");
}
