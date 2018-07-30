using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Application.ViewModel
{
    public class GrupoViewModel
    {
        public string Nome { get; set; }
        public FilmeViewModel Primeiro { get; set; }
        public FilmeViewModel Segundo { get; set; }
        public List<FilmeViewModel> Filmes { get; set; }
    }
}
