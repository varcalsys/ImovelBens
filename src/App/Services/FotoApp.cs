using System.Collections.Generic;
using ImovelBens.App.Contracts;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;

namespace ImovelBens.App.Services
{
    public class FotoApp: IFotoApp
    {
        private readonly IFotoService _fotoService;

        public FotoApp(IFotoService fotoService)
        {
            _fotoService = fotoService;
        }

        public void Register(Foto entity)
        {
            _fotoService.Add(entity);
        }

        public Foto GetById(int id)
        {
            return _fotoService.GetById(id);
        }

        public IEnumerable<Foto> GetAll()
        {
           return _fotoService.GetAll();
        }


        public void Commit()
        {
            _fotoService.Commit();
        }

    }
}
