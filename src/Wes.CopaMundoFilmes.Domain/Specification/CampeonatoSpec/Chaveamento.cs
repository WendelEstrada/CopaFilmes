using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;

namespace Wes.CopaMundoFilmes.Domain.Specification.CampeonatoSpec
{
    public class Chaveamento
    {
        public static List<Grupo> MontarGrupos(List<Filme> filmes)
        {
            var grupos = new List<Grupo>();
            var nomesDosGrupos = new[] { "A", "B", "C", "D" };

            for (int i = 0; i < 4; i++)
            {
                var grupo = new Grupo()
                {
                    Nome = nomesDosGrupos[i],
                    Filmes = new List<Filme>
                    (
                        filmes
                        .OrderBy(f => f.PrimaryTitle)
                        .Skip(4 * i)
                        .Take(4)
                    )
                };

                grupos.Add(grupo);
            }

            return grupos;
        }

        public static void IdentificarCabecasDeGrupo(List<Grupo> grupos)
        {
            foreach (var grupo in grupos)
            {
                var cabecasDeGrupo = grupo
                                    .Filmes
                                    .OrderByDescending(f => f.AverageRating)
                                    .ThenBy(f => f.PrimaryTitle)
                                    .Take(2);

                grupo.Primeiro = cabecasDeGrupo.First();
                grupo.Segundo = cabecasDeGrupo.Last();
            }
        }
    }
}
