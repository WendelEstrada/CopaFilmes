using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Application.Services.Interfaces;
using Wes.CopaMundoFilmes.Application.ViewModel;
using Wes.CopaMundoFilmes.Domain.Interfaces.Services;

namespace Wes.CopaMundoFilmes.Application.Services
{
    public class FilmeAppService : IFilmeAppService
    {
        private readonly IFilmeService filmeService;

        public FilmeAppService(IFilmeService filmeService)
        {
            this.filmeService = filmeService;
        }

        public IEnumerable<FilmeViewModel> ObterTodosFilmes()
        {
            return Mapper.Map<IEnumerable<FilmeViewModel>>(filmeService.ObterTodosFilmes());
        }
    }
}
