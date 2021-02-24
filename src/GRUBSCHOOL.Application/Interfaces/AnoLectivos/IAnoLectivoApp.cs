using GRUBSCHOOL.Application.ViewModels;
using GRUBSCHOOL.Domain.Entidades;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Application.Interfaces
{
    public interface IAnoLectivoApp : IGenericaApp<AnoLectivoViewModel>
    {
        Task<AnoLectivoViewModel> BuscarPorAno(int ano);
    }
}
