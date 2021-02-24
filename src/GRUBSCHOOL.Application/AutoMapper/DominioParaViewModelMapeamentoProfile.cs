using AutoMapper;
using GRUBSCHOOL.Application.ViewModels;
using GRUBSCHOOL.Domain.Entidades;

namespace GRUBSCHOOL.Application.AutoMapper
{
    public class DominioParaViewModelMapeamentoProfile : Profile
    {
        public DominioParaViewModelMapeamentoProfile()
        {
            CreateMap<AnoLectivo, AnoLectivoViewModel>();
        }
    }
}
