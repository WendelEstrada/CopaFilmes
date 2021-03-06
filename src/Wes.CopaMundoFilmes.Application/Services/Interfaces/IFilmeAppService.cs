﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Application.ViewModel;

namespace Wes.CopaMundoFilmes.Application.Services.Interfaces
{
    public interface IFilmeAppService
    {
        IEnumerable<FilmeViewModel> ObterTodosFilmes();
    }
}
