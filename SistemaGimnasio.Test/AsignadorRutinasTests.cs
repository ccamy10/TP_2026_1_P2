using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Test
{
    public class AsignadorRutinasTests
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarCorrectamente()
        {
            //Arrange
            Usuario usuario = new Usuario("María", 30, "Mejorar resistencia");
            Rutina rutina = new Rutina("Rutina de resistencia", 60);

            AsignadorRutinas asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarRutinaUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]

        public void AsignarUsuarioAEntrenador_DebeIncuirUsuario()
        {
            //Arrange
            Usuario usuario = new Usuario("Pedro", 35, "Perder peso");
            Entrenador entrenador = new Entrenador("Ana", "Especialista en pérdida de peso");
            AsignadorRutinas asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarUsuarioEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
