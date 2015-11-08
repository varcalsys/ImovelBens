using System.Collections.Generic;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Domain.Services
{
    public class FotoService:ServiceBase<Foto>, IFotoService
    {

        private readonly IFotoRepository _fotoRepository;


        public FotoService(IFotoRepository fotoRepository) :
            base(fotoRepository)
        {
            _fotoRepository = fotoRepository;
        }

    }
}
