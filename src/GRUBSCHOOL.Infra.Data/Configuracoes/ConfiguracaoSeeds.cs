using GRUBSCHOOL.Infra.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace GRUBSCHOOL.Infra.Data.Configuracoes
{
    public static class ConfiguracaoSeeds
    {
        public static void AplicarConfiguracao(ModelBuilder modelBuilder)
        {
            RegiaoSeed.Seed(modelBuilder);
            CicloSeed.Seed(modelBuilder);
            ClasseSeed.Seed(modelBuilder);
            CursoTipoSeed.Seed(modelBuilder);
            PeriodoSeed.Seed(modelBuilder);
        }
    }
}
