using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Application.ViewModel
{
    public class FilmeViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Título")]
        public string PrimaryTitle { get; set; }

        [Display(Name = "Ano")]
        public int Year { get; set; }

        [Display(Name = "Nota")]
        public Double AverageRating { get; set; }
    }
}
