using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;
using Wes.CopaMundoFilmes.Domain.Interfaces.Services;
using Wes.CopaMundoFilmes.Domain.Specification.CampeonatoSpec;

namespace Wes.CopaMundoFilmes.Domain.Services
{
    public class CampeonatoService : ICampeonatoService
    {
        public Campeonato Campeonato { get; private set; }

        public void MontarGrupos(List<Filme> filmes)
        {
            Campeonato = new Campeonato
            {
                Grupos = Chaveamento.MontarGrupos(filmes)
            };

            Chaveamento.IdentificarCabecasDeGrupo(Campeonato.Grupos);
        }

        public void RealizarPartidasDaFaseDeEliminatorias()
        {
            Campeonato.RealizarPartida("A", "B");
            Campeonato.RealizarPartida("B", "A");
            Campeonato.RealizarPartida("C", "D");
            Campeonato.RealizarPartida("D", "C");
        }

        public void RealizarPartidasDaSemiFinal()
        {
            Campeonato.RealizarPartida(1, 2);
            Campeonato.RealizarPartida(3, 4);
        }

        public void RealizarPartidaFinal()
        {
            Campeonato.RealizarPartida(5, 6);
            Campeonato.DefinirPrimeirosColocados();
        }
    }
}
