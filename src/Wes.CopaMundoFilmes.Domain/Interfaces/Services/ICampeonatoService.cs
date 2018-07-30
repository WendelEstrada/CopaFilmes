using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;

namespace Wes.CopaMundoFilmes.Domain.Interfaces.Services
{
    public interface ICampeonatoService
    {
        Campeonato Campeonato { get; }

        void MontarGrupos(List<Filme> filmes);
        void RealizarPartidasDaFaseDeEliminatorias();
        void RealizarPartidasDaSemiFinal();
        void RealizarPartidaFinal();
    }
}
