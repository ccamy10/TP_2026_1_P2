using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class UsuarioTests
    {
        [Fact] //Prueba lo que contiene el metodo
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange

            Usuario usuario = new Usuario("Carlos", 28, "Ganar masa muscular");
            Rutina rutina = new Rutina("Rutina de fuerza", 90);

            //Act

            usuario.AsignarRutina(rutina);

            //Assert

            Assert.Equal("Rutina de fuerza", usuario.RutinaAsignada.Nombre); //Que se va a comprobar que sea igual
        }
    }
}