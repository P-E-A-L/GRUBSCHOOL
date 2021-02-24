using GRUBSCHOOL.Domain.Entidades;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Domain.Interfaces.Servicos
{
    public interface IAnoLectivoServico : IGenericoServico<AnoLectivo>
    {
        Task<AnoLectivo> BuscarPorAno(int ano);
    }
}
