using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Domain.Entities;

namespace Wes.CopaMundoFilmes.Domain.Test.Helpers
{
    public class FilmeHelper
    {
        public static List<Filme> Filmes { get; } = new List<Filme>()
        {
            new Filme("tt3606756", "Os Incríveis 2", 2018, 8.5),
            new Filme("tt4881806", "Jurassic World: Reino Ameaçado", 2018, 6.7),
            new Filme("tt5164214", "Oito Mulheres e um Segredo", 2018, 6.3),
            new Filme("tt7784604", "Hereditário", 2018, 7.8),
            new Filme("tt4154756", "Vingadores: Guerra Infinita", 2018, 8.8),
            new Filme("tt5463162", "Deadpool 2", 2018, 8.1),
            new Filme("tt3778644", "Han Solo: Uma História Star Wars", 2018, 7.2),
            new Filme("tt3501632", "Thor: Ragnarok", 2017, 7.9),
            new Filme("tt2854926", "Te Peguei!", 2018, 7.1),
            new Filme("tt0317705", "Os Incríveis", 2004, 8.0),
            new Filme("tt3799232", "A Barraca do Beijo", 2018, 6.4),
            new Filme("tt1365519", "Tomb Raider: A Origem", 2018, 6.5),
            new Filme("tt1825683", "Pantera Negra", 2018, 7.5),
            new Filme("tt5834262", "Hotel Artemis", 2018, 6.3),
            new Filme("tt7690670", "Superfly", 2018, 5.1),
            new Filme("tt1485796", "O Rei do Show", 2017, 7.7)
        };
    }
}
