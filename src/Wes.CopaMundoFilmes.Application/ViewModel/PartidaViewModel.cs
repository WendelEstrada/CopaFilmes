using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Application.ViewModel
{
    public class PartidaViewModel
    {
        public int Id { get; private set; }
        public FilmeViewModel PrimeiroFilme { get; private set; }
        public FilmeViewModel SegundoFilme { get; private set; }
        public FilmeViewModel Vencedor { get; private set; }
        public FilmeViewModel Perdedor { get; private set; }
    }
}
