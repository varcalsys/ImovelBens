using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Entities;
using ImovelBens.Infra.Data.Context;
using ImovelBens.Infra.Data.Repositories.Core;

namespace ImovelBens.Infra.Data.Repositories
{
    public class FotoRepository: RepositoryBase<Foto>, IFotoRepository
    {
        public FotoRepository(AppDbContext db) : base(db)
        {
            Db = db;
        }
    }
}
