using GRUBSCHOOL.Application.Aplicacoes;
using GRUBSCHOOL.Application.AutoMapper;
using GRUBSCHOOL.Application.Interfaces;
using GRUBSCHOOL.Domain.Interfaces;
using GRUBSCHOOL.Domain.Interfaces.Repositorios;
using GRUBSCHOOL.Domain.Interfaces.Servicos;
using GRUBSCHOOL.Domain.Servicos;
using GRUBSCHOOL.Infra.Data.Configuracoes;
using GRUBSCHOOL.Infra.Data.Interfaces;
using GRUBSCHOOL.Infra.Data.Repositorios;
using GRUBSCHOOL.Infra.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace GRUBSCHOOL.CrossCutting.IoC
{
    public class NativeInjectorMapping
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ContextoDatabase>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddSingleton(AutoMapperConfiguracao.RegisterMappings().CreateMapper());
            service.AddScoped(typeof(IGenericoRepositorio<>), typeof(GenericoRepositorio<>));

            //===============================================================================================================
            //Anoo Lectivos                                                                                                     ==
            //===============================================================================================================
            service.AddScoped<IAnoLectivoApp, AnoLectivoApp>();
            service.AddScoped<IAnoLectivoServico, AnoLectivoServico>();
            service.AddScoped<IAnoLectivoRepositorio, AnoLectivoRepositorio>();


        }
    }
}
