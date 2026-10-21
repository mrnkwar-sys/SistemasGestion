using System.Globalization;

var cultura = new CultureInfo("es-ES");
var fechaHoraActual = DateTime.Now;
var fechaActual = fechaHoraActual.Date;
var haceTreintaDias = fechaActual.AddDays(-30);
var dentroDeTreintaDias = fechaActual.AddDays(30);
var calendario = cultura.Calendar;
var numeroSemana = calendario.GetWeekOfYear(
    fechaActual,
    CalendarWeekRule.FirstFourDayWeek,
    DayOfWeek.Monday);
var sistemaOperativo = OperatingSystem.IsWindows() ? "Windows" : Environment.OSVersion.Platform.ToString();
var arquitectura = Environment.Is64BitProcess ? "x64" : "x86";

Console.WriteLine("==================================================");
Console.WriteLine("INFORME DEL SISTEMA");
Console.WriteLine("==================================================");
Console.WriteLine();

Console.WriteLine("FECHA Y HORA");
Console.WriteLine("------------");
Console.WriteLine($"Fecha: {fechaActual.ToString("dddd, d 'de' MMMM 'de' yyyy", cultura)}");
Console.WriteLine($"Hora: {fechaHoraActual:HH:mm:ss}");
Console.WriteLine($"Día de la semana: {fechaActual.ToString("dddd", cultura)}");
Console.WriteLine($"Día del año: {fechaActual.DayOfYear}");
Console.WriteLine($"Semana del año: {numeroSemana}");
Console.WriteLine();

Console.WriteLine("FECHA DE EJECUCIÓN");
Console.WriteLine("------------------");
Console.WriteLine($"Fecha actual: {fechaActual:dd/MM/yyyy}");
Console.WriteLine($"Hace 30 días era: {haceTreintaDias:dd/MM/yyyy}");
Console.WriteLine($"Dentro de 30 días será: {dentroDeTreintaDias:dd/MM/yyyy}");
Console.WriteLine();

Console.WriteLine("SISTEMA");
Console.WriteLine("-------");
Console.WriteLine($"Sistema operativo: {sistemaOperativo}");
Console.WriteLine($"Arquitectura: {arquitectura}");
Console.WriteLine($"Nombre del equipo: {Environment.MachineName}");
Console.WriteLine($"Directorio actual: {Environment.CurrentDirectory}");
Console.WriteLine();
Console.WriteLine("==================================================");
