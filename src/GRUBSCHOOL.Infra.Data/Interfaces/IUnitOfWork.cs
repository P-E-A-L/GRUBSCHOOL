using System.Threading.Tasks;

namespace GRUBSCHOOL.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
