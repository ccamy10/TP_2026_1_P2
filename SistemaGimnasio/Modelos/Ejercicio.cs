namespace SistemaGimnasio.Modelos;

public class Ejercicio
{
    public string Nombre { get; set; }
    public int Series { get; set; }
    public int Repeticiones { get; set; }
    public int Descanso { get; set; }
    public Ejercicio(string nombre, int series, int repeticiones, int descanso)
    {
        Nombre = nombre;
        Series = series;
        Repeticiones = repeticiones;
        Descanso = descanso;
    }
}
   