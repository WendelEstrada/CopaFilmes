using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;
using Wes.CopaMundoFilmes.Domain.Interfaces.RestServices;
using Wes.CopaMundoFilmes.Domain.Interfaces.Services;

namespace Wes.CopaMundoFilmes.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRestService filmeRestService;

        public FilmeService(IFilmeRestService filmeRestService)
        {
            this.filmeRestService = filmeRestService;
        }

        public IEnumerable<Filme> ObterTodosFilmes()
        {
            return filmeRestService.ObterTodosFilmes();
        }
    }
}
