using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Domain.Entities.EqualityCompare
{
    public class GrupoComparer : IEqualityComparer<Grupo>
    {
        public bool Equals(Grupo x, Grupo y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x is null || y is null)
                return false;

            return x.Nome == y.Nome;
        }

        public int GetHashCode(Grupo grupo)
        {
            throw new NotImplementedException();
        }
    }
}
