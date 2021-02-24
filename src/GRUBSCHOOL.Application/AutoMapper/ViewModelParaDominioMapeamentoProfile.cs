using AutoMapper;
using GRUBSCHOOL.Application.ViewModels;
using GRUBSCHOOL.Domain.Entidades;

namespace GRUBSCHOOL.Application.AutoMapper
{
    public class ViewModelParaDominioMapeamentoProfile : Profile
    {
        public ViewModelParaDominioMapeamentoProfile()
        {
            CreateMap<AnoLectivoViewModel, AnoLectivo>();
        }
    }
}
