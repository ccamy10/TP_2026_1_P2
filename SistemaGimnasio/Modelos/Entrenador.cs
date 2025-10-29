namespace SistemaGimnasio.Modelos;

public class Entrenador
{
    public string Nombre { get; set; }
    public string Especialidad { get; set; }
    private List<Usuario> usuariosAsignados;

    public Entrenador(string nombre, string especialidad)
    {
        Nombre = nombre;
        Especialidad = especialidad;
        usuariosAsignados = new List<Usuario>();
    }

    public void AsignarUsuario(Usuario usuario)
    {
        usuariosAsignados.Add(usuario);
    }

    public List<Usuario> ObtenerUsuariosAsignados()
    {
        return usuariosAsignados;
    }
}