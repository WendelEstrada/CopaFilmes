using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Application.ViewModel;
using Wes.CopaMundoFilmes.Domain.Entities;

namespace Wes.CopaMundoFilmes.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base()
        {
            CreateMap<FilmeViewModel, Filme>();
        }
    }
}
