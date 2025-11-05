using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

// Configurar colores
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║       SISTEMA DE GESTIÓN DE GIMNASIO                       ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
Console.ResetColor();

// ===== CREAR USUARIO =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n┌─────────────────────────────────────┐");
Console.WriteLine("│      REGISTRO DE USUARIO            │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa el nombre del usuario: ");
Console.ForegroundColor = ConsoleColor.Green;
string nonbreUsuario = Console.ReadLine() ?? "";

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa la edad del usuario: ");
Console.ForegroundColor = ConsoleColor.Green;
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa el objetivo del usuario (Fuerza, Resitencia, Musculo, etc): ");
Console.ForegroundColor = ConsoleColor.Green;
string objetivoUsuario = Console.ReadLine() ?? "";
Console.ResetColor();

Usuario usuario = new Usuario(nonbreUsuario, edadUsuario, objetivoUsuario);

// ===== CREAR ENTRENADOR =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n┌─────────────────────────────────────┐");
Console.WriteLine("│      REGISTRO DE ENTRENADOR         │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa el nombre del entrenador: ");
Console.ForegroundColor = ConsoleColor.Green;
string nombreEntrenador = Console.ReadLine() ?? "";

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa la especialidad del entrenador: ");
Console.ForegroundColor = ConsoleColor.Green;
string especialidadEntrenador = Console.ReadLine() ?? "";
Console.ResetColor();

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

// ===== CREAR RUTINA =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n┌─────────────────────────────────────┐");
Console.WriteLine("│      CREACIÓN DE RUTINA             │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa el nombre de la rutina: ");
Console.ForegroundColor = ConsoleColor.Green;
string nombreRutina = Console.ReadLine() ?? "";

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa la duración de la rutina en minutos: ");
Console.ForegroundColor = ConsoleColor.Green;
int duracionRutina = int.Parse(Console.ReadLine() ?? "0");
Console.ResetColor();

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

// ===== ASIGNAR EJERCICIOS =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n┌─────────────────────────────────────┐");
Console.WriteLine("│      AGREGAR EJERCICIOS             │");
Console.WriteLine("└─────────────────────────────────────┘");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("¿Cuántos ejercicios deseas agregar a la rutina? ");
Console.ForegroundColor = ConsoleColor.Green;
int numEjercicios = int.Parse(Console.ReadLine() ?? "0");
Console.ResetColor();

int contadorEjercicios = 0;
while (numEjercicios > 0)
{
    contadorEjercicios++;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"\n  ▶ Ejercicio #{contadorEjercicios}:");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("    Nombre del ejercicio: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string nombreEjercicio = Console.ReadLine() ?? "";

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("    Número de repeticiones: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int repeticiones = int.Parse(Console.ReadLine() ?? "0");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("    Número de series: ");
    Console.ForegroundColor = ConsoleColor.Green;
    int series = int.Parse(Console.ReadLine() ?? "0");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("    Tiempo de descanso (seg): ");
    Console.ForegroundColor = ConsoleColor.Green;
    int descanso = int.Parse(Console.ReadLine() ?? "0");
    Console.ResetColor();

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
    numEjercicios--;
}

// ===== ASIGNAR RUTINA Y ENTRENADOR =====
AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaUsuario(usuario, rutina);
asignador.AsignarUsuarioEntrenador(usuario, entrenador);

// ===== MOSTRAR RESUMEN =====
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\n╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    RESUMEN FINAL                           ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n👤 Usuario: {usuario.Nombre}, {usuario.Edad} años");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"   Objetivo: {usuario.Objetivo}");
Console.WriteLine($"   Rutina: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"   Duración: {usuario.RutinaAsignada.Duracion} minutos");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n💪 Ejercicios:");
Console.ResetColor();

foreach (Ejercicio ejercicio in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("   ✓ ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{ejercicio.Nombre}: {ejercicio.Series} series de {ejercicio.Repeticiones} repeticiones, Descanso: {ejercicio.Descanso} seg");
}
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n🏋️Entrenador asignado: {entrenador.Nombre}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"   Especialidad: {entrenador.Especialidad}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n════════════════════════════════════════════════════════════");
Console.WriteLine("         ¡Registro completado exitosamente! ");
Console.WriteLine("════════════════════════════════════════════════════════════\n");
Console.ResetColor();
