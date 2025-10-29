using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorRutinas
    {
        private List<Rutina> rutinas;
        public GestorRutinas()
        {
            rutinas = new List<Rutina>();
        }
        public void CrearRutina(string nombre, int duracion)
        {
            rutinas.Add(new Rutina(nombre, duracion));
        }
        public Rutina BuscarRutina(string nombre)
        {
            return rutinas.FirstOrDefault(r => r.Nombre == nombre);
        }
    }
}
