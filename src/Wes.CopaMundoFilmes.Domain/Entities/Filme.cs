using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Domain.Entities
{
    public class Filme
    {
        public Filme(string id, string primaryTitle, int year, double averageRating)
        {
            Id = id;
            PrimaryTitle = primaryTitle;
            Year = year;
            AverageRating = averageRating;
        }

        public string Id { get; private set; }
        public string PrimaryTitle { get; private set; }
        public int Year { get; private set; }
        public Double AverageRating { get; private set; }
    }
}
