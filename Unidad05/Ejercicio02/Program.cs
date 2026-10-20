using Ejercicio02;

var persona = new clsPersona
{
    Nombre = "Nombre",
    Apellidos = "Apellidos",
    FechaNacimiento = new DateTime(2000, 1, 1),
    Edad = 25
};

Console.WriteLine($"{persona.Nombre} {persona.Apellidos}");
Console.WriteLine($"Fecha de nacimiento: {persona.FechaNacimiento:d}");
Console.WriteLine($"Edad: {persona.Edad}");
