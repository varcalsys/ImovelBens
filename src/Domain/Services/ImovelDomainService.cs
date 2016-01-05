using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;
using ImovelBens.Domain.Services.Core;

namespace ImovelBens.Domain.Services
{
    public class ImovelDomainService:DomainServiceBase<Imovel>, IImovelDomainService
    {
        private IImovelRepository _imovelRepository;
        public ImovelDomainService(IImovelRepository imovelRepository) : base(imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }
    }
}
