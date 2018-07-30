using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;

namespace Wes.CopaMundoFilmes.Domain.Interfaces.RestServices
{
    public interface IFilmeRestService
    {
        IEnumerable<Filme> ObterTodosFilmes();
    }
}
