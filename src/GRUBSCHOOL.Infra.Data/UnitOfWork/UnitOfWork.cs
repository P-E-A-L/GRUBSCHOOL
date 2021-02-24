using GRUBSCHOOL.Infra.Data.Configuracoes;
using GRUBSCHOOL.Infra.Data.Interfaces;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextoDatabase _contexto;

        public UnitOfWork(ContextoDatabase contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Commit()
        {
                return (await _contexto.SaveChangesAsync()) > 0;
        }

        public void Dispose() =>
            _contexto.Dispose();

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
