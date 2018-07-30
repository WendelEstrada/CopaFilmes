using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Application.Services.Interfaces;
using Wes.CopaMundoFilmes.Application.ViewModel;
using Wes.CopaMundoFilmes.Domain.Entities;
using Wes.CopaMundoFilmes.Domain.Interfaces.Services;

namespace Wes.CopaMundoFilmes.Application.Services
{
    public class CampeonatoAppService : ICampeonatoAppService
    {
        private readonly ICampeonatoService campeonatoService;

        public CampeonatoViewModel CampeonatoViewModel { get; private set; }

        public CampeonatoAppService(ICampeonatoService campeonatoService)
        {
            this.campeonatoService = campeonatoService;
        }

        public void Iniciar(List<FilmeViewModel> filmeViewModels)
        {
            var filmes = Mapper.Map<List<Filme>>(filmeViewModels);

            campeonatoService.MontarGrupos(filmes);
            campeonatoService.RealizarPartidasDaFaseDeEliminatorias();
            campeonatoService.RealizarPartidasDaSemiFinal();
            campeonatoService.RealizarPartidaFinal();

            CampeonatoViewModel = Mapper.Map<CampeonatoViewModel>(campeonatoService.Campeonato);
        }
    }
}
