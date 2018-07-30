using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wes.CopaMundoFilmes.Application.Services;
using Wes.CopaMundoFilmes.Application.Services.Interfaces;
using Wes.CopaMundoFilmes.Domain.Interfaces.RestServices;
using Wes.CopaMundoFilmes.Domain.Interfaces.Services;
using Wes.CopaMundoFilmes.Domain.Services;
using Wes.CopaMundoFilmes.Infra.Data.RestServices;

namespace Wes.CopaMundoFilmes.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            // App
            container.Register<IFilmeAppService, FilmeAppService>(Lifestyle.Scoped);
            container.Register<ICampeonatoAppService, CampeonatoAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IFilmeService, FilmeService>(Lifestyle.Scoped);
            container.Register<ICampeonatoService, CampeonatoService>(Lifestyle.Scoped);

            // Rest
            container.Register<IFilmeRestService, FilmeRestService>(Lifestyle.Scoped);
        }
    }
}
