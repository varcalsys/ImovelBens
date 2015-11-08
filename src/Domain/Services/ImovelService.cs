using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Domain.Services
{
    public class ImovelService: ServiceBase<Imovel>, IImovelService
    {
        private readonly IImovelRepository _imovelRepository;

        public ImovelService(IImovelRepository imovelRepository)
            :base(imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }


       
    }
}
