using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;
using Wes.CopaMundoFilmes.Domain.Interfaces.RestServices;
using Wes.CopaMundoFilmes.Infra.Data.RestApi;

namespace Wes.CopaMundoFilmes.Infra.Data.RestServices
{
    public class FilmeRestService : IFilmeRestService
    {
        public IEnumerable<Filme> ObterTodosFilmes()
        {
            var cliente = new BaseClient<List<Filme>>();
            cliente.RealizarChamada();
            return cliente.Dados;
        }
    }
}
