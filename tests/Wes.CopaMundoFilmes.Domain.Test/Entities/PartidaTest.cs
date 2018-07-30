using Wes.CopaMundoFilmes.Domain.Entities;
using Xunit;

namespace Wes.CopaMundoFilmes.Domain.Test.Entities
{
    public class PartidaTest
    {
        [Fact]
        public void Partida_Identificar_Vencedor_No_Criterio_De_Desempate()
        {
            // Arrange
            var filmeBladeRunner = new Filme("tt1856101", "Blade Runner 2049", 2017, 8.1);
            var filmeJurassicPark = new Filme("tt0107290", "Jurassic Park: O Parque dos Dinossauros", 1993, 8.1);
            var partida = new Partida(0, filmeBladeRunner, filmeJurassicPark);

            // Act
            partida.Iniciar();

            // Assert
            Assert.Equal(filmeBladeRunner.Id, partida.Vencedor.Id);
            Assert.Equal(filmeJurassicPark.Id, partida.Perdedor.Id);
        }

        [Fact]
        public void Partida_IdentificarVencedor_VencedorOk()
        {
            // Arrange
            var filmeOsIncriveis2 = new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5);
            var filmeOitoMulheres = new Filme("tt5164214", "Oito Mulheres e um Segredo", 2018, 6.3);
            var partida = new Partida(0, filmeOsIncriveis2, filmeOitoMulheres);

            // Act
            partida.Iniciar();

            // Assert
            Assert.Equal(filmeOsIncriveis2.Id, partida.Vencedor.Id);
            Assert.Equal(filmeOitoMulheres.Id, partida.Perdedor.Id);
        }
    }
}
