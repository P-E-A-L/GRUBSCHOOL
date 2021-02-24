using GRUBSCHOOL.Domain.Entidades;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Domain.Interfaces.Repositorios
{
    public interface IAnoLectivoRepositorio: IGenericoRepositorio<AnoLectivo>
    {
        Task<AnoLectivo> BuscarPorAno(int ano);
    }
}
