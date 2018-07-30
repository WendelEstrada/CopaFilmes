using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Domain.Entities
{
    public class Grupo
    {
        public string Nome { get; set; }
        public Filme Primeiro { get; set; }
        public Filme Segundo { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}
