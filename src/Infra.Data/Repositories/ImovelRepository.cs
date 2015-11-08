using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Infra.Data.Repositories
{
    public class ImovelRepository:RepositoryBase<Imovel>, IImovelRepository
    {
        public ICollection<Foto> GetByImagesImovelId(int id)
        {
            var fotos = _context.Fotos.Where(x => x.ImovelId == id);

            return fotos.ToList();
        }

        public override IQueryable<Imovel> GetAll()
        {
            var imoveis = from i in _context.Imoveis.Include("Fotos") select i;
            return imoveis;
        }

        public override Imovel GetById(int id)
        {
            var imovel = from i in _context.Imoveis.Where(x => x.Id == id).Include("Fotos") select i;

            return imovel.FirstOrDefault();
        }
    }
}
