namespace SistemaGimnasio.Test
{
    using SistemaGimnasio.Modelos;
    public class EntrenadorTests
    {
        [Fact]
        public void AgregarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange
            Usuario usuario = new Usuario("Ana", 25, "Perder peso");
            Entrenador entrenador = new Entrenador("Luis", "Especialista en pérdida de peso");

            //Act
            entrenador.AsignarUsuario(usuario);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
