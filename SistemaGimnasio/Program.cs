using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

Console.WriteLine("Sistema de Gestión de Gimnasio");

//Crear Usuario

Console.WriteLine("Ingresa el nombre del usuario:");
string nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario(aumentar Fuerza, Resistencia, etc.):");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear Entrenador

Console.WriteLine("Ingresa el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador:");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);


//Crear Rutina

Console.WriteLine("Ingresa el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duración de la rutina (en minutos):");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina

Console.WriteLine("¿Cuántos ejercicios tendra la rutina?: ");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

int contadorEjercicios = 0;

while (numEjercicios > 0)
    {
        contadorEjercicios++;
        Console.WriteLine($"Ejercicio #{contadorEjercicios}");
        
        Console.WriteLine("Ingresa el nombre del ejercicio:");
        string nombreEjercicio =  Console.ReadLine() ?? "";

        Console.WriteLine("Ingresa las repeticiones del ejercicio:");
        int repeticiones = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Ingresa el número de series del ejercicio:");
        int series = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Ingresa el tiempo de descanso entre series (en minutos):");
        int descanso = int.Parse(Console.ReadLine() ?? "");

        Ejercicio ejercicio = new Ejercicio(nombreEjercicio, series, repeticiones, descanso);
        
        rutina.AgregarEjercicio(ejercicio);

        numEjercicios--;
    }

//Asignar rutina y  entrenador

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaUsuario(usuario, rutina);
asignador.AsignarUsuarioEntrenador(usuario, entrenador);


//Mostrar resumen

Console.WriteLine("\nResumen del Usuario");
Console.WriteLine($"Nombre: {usuario.Nombre}");
Console.WriteLine($"Edad: {usuario.Edad}");
Console.WriteLine($"Objetivo: {usuario.Objetivo}");

Console.WriteLine($"\nRutina Asignada: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"Duración: {usuario.RutinaAsignada.Duracion} minutos");

Console.WriteLine("Ejercicios:");
foreach (Ejercicio e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"- {e.Nombre}: | {e.Series} series de {e.Repeticiones} repeticiones | Descanso: {e.Descanso} minutos");
}

Console.WriteLine($"\nEntrenador Asignado: {entrenador.Nombre}");
Console.WriteLine($"Especialidad: {entrenador.Especialidad}");

