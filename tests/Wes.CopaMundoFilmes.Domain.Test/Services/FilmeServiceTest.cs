using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Interfaces.RestServices;
using Wes.CopaMundoFilmes.Domain.Services;
using Wes.CopaMundoFilmes.Domain.Test.Helpers;
using Xunit;

namespace Wes.CopaMundoFilmes.Domain.Test.Services
{
    public class FilmeServiceTest
    {
        [Fact]
        public void FilmeService_ObterListaDeFilmes_FilmesRetornados()
        {
            // Arrange
            var service = new Mock<IFilmeRestService>();
            var filmes = FilmeHelper.Filmes;

            service.Setup(s => s.ObterTodosFilmes()).Returns(filmes);
            var filmeService = new FilmeService(service.Object);

            // Act
            var filmesRetornados = filmeService.ObterTodosFilmes();

            // Assert
            Assert.True(filmes.Count == filmesRetornados.Count());
        }
    }
}
