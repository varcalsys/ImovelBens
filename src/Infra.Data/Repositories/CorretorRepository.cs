
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Entities;
using ImovelBens.Infra.Data.Context;
using ImovelBens.Infra.Data.Repositories.Core;

namespace ImovelBens.Infra.Data.Repositories
{
    public class CorretorRepository: RepositoryBase<Corretor>, ICorretorRepository
    {
        public CorretorRepository(AppDbContext db) : base(db)
        {
            Db = db;
        }
    }
}
