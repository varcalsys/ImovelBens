using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;
using ImovelBens.Domain.Services.Core;

namespace ImovelBens.Domain.Services
{
    public class CorretoDomainService: DomainServiceBase<Corretor>, ICorretorDomainService
    {
        private readonly ICorretorRepository _corretorRepository;

        public CorretoDomainService(ICorretorRepository corretorRepository) : base(corretorRepository)
        {
            _corretorRepository = corretorRepository;
        }
    }
}
