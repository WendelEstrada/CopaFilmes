using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;
using Wes.CopaMundoFilmes.Domain.Services;
using Wes.CopaMundoFilmes.Domain.Test.Helpers;
using Xunit;

namespace Wes.CopaMundoFilmes.Domain.Test.Services
{
    public class CampeonatoServiceTest
    {
        private readonly CampeonatoService campeonatoService = new CampeonatoService();

        [Fact]
        public void CampeonatoService_MontarGrupo_GruposOk()
        {
            // Arrange
            var filmes = FilmeHelper.Filmes;

            // Act
            campeonatoService.MontarGrupos(filmes);

            // Assert
            Assert.True(campeonatoService.Campeonato.Grupos.Count == 4);
        }

        [Fact]
        public void CampeonatoService_RealizarPartidasDasFasesEliminatorias_PartidasOk()
        {
            // Arrange
            var filmes = FilmeHelper.Filmes;

            // Act
            campeonatoService.MontarGrupos(filmes);
            campeonatoService.RealizarPartidasDaFaseDeEliminatorias();

            // Assert
            Assert.Equal(ObterVencedorPorPartida(0).Id, ObterFilmeStubPorNome("Deadpool 2").Id);
            Assert.Equal(ObterPerdedorPorPartida(0).Id, ObterFilmeStubPorNome("Jurassic World: Reino Ameaçado").Id);

            Assert.Equal(ObterVencedorPorPartida(1).Id, ObterFilmeStubPorNome("Hereditário").Id);
            Assert.Equal(ObterPerdedorPorPartida(1).Id, ObterFilmeStubPorNome("O Rei do Show").Id);

            Assert.Equal(ObterVencedorPorPartida(2).Id, ObterFilmeStubPorNome("Os Incríveis 2").Id);
            Assert.Equal(ObterPerdedorPorPartida(2).Id, ObterFilmeStubPorNome("Thor: Ragnarok").Id);

            Assert.Equal(ObterVencedorPorPartida(3).Id, ObterFilmeStubPorNome("Vingadores: Guerra Infinita").Id);
            Assert.Equal(ObterPerdedorPorPartida(3).Id, ObterFilmeStubPorNome("Os Incríveis").Id);
        }

        [Fact]
        public void CampeonatoService_RealizarPartidasDaSemiFinal_PartidasOk()
        {
            // Arrange
            var filmes = FilmeHelper.Filmes;

            // Act
            campeonatoService.MontarGrupos(filmes);
            campeonatoService.RealizarPartidasDaFaseDeEliminatorias();
            campeonatoService.RealizarPartidasDaSemiFinal();

            // Assert
            Assert.Equal(ObterVencedorPorPartida(4).Id, ObterFilmeStubPorNome("Deadpool 2").Id);
            Assert.Equal(ObterPerdedorPorPartida(4).Id, ObterFilmeStubPorNome("Hereditário").Id);

            Assert.Equal(ObterVencedorPorPartida(5).Id, ObterFilmeStubPorNome("Vingadores: Guerra Infinita").Id);
            Assert.Equal(ObterPerdedorPorPartida(5).Id, ObterFilmeStubPorNome("Os Incríveis 2").Id);
        }

        [Fact]
        public void CampeonatoService_RealizarPartidaFinal_PartidaOk()
        {
            // Arrange
            var filmes = FilmeHelper.Filmes;

            // Act
            campeonatoService.MontarGrupos(filmes);
            campeonatoService.RealizarPartidasDaFaseDeEliminatorias();
            campeonatoService.RealizarPartidasDaSemiFinal();
            campeonatoService.RealizarPartidaFinal();

            // Assert
            Assert.Equal(campeonatoService.Campeonato.Campeao.Id, ObterFilmeStubPorNome("Vingadores: Guerra Infinita").Id);
            Assert.Equal(campeonatoService.Campeonato.Segundo.Id, ObterFilmeStubPorNome("Deadpool 2").Id);
            Assert.Equal(campeonatoService.Campeonato.Terceiro.Id, ObterFilmeStubPorNome("Os Incríveis 2").Id);
        }

        private Filme ObterVencedorPorPartida(int numeroDaPartida)
        {
            return campeonatoService.Campeonato.Partidas[numeroDaPartida].Vencedor;
        }

        private Filme ObterPerdedorPorPartida(int numeroDaPartida)
        {
            return campeonatoService.Campeonato.Partidas[numeroDaPartida].Perdedor;
        }

        private Filme ObterFilmeStubPorNome(string nome)
        {
            return FilmeHelper.Filmes.First(f => f.PrimaryTitle == nome);
        }
    }
}
