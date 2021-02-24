using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Domain.Interfaces.Repositorios;
using GRUBSCHOOL.Infra.Data.Configuracoes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Infra.Data.Repositorios
{
    public class AnoLectivoRepositorio : GenericoRepositorio<AnoLectivo>, IAnoLectivoRepositorio
    {
        public AnoLectivoRepositorio(ContextoDatabase contextoDatabase) : base(contextoDatabase)
        {
        }

        public async Task<AnoLectivo> BuscarPorAno(int ano)
        {
            return await DbSet.AsNoTracking()
               .Where(c => c.Ano == ano)
               .FirstOrDefaultAsync();
        }
    }
}
