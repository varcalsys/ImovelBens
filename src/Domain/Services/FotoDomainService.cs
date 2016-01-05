

using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;
using ImovelBens.Domain.Services.Core;

namespace ImovelBens.Domain.Services
{
    public class FotoDomainService:DomainServiceBase<Foto>, IFotoDomainService
    {

        private readonly IFotoRepository _fotoRepository;

        public FotoDomainService(IFotoRepository fotoRepository) : base(fotoRepository)
        {
            _fotoRepository = fotoRepository;
        }
    }
}
