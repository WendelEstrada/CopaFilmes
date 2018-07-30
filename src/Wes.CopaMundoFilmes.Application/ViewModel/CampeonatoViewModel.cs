using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Application.ViewModel
{
    public class CampeonatoViewModel
    {
        public FilmeViewModel Campeao { get; private set; }
        public FilmeViewModel Segundo { get; private set; }
        public FilmeViewModel Terceiro { get; private set; }
        public List<GrupoViewModel> Grupos { get; private set; }
        public List<PartidaViewModel> Partidas { get; private set; }
    }
}
