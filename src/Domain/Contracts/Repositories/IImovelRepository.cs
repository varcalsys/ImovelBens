using System.Collections.Generic;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Domain.Contracts.Repositories
{
    public interface IImovelRepository: IRepositoryBase<Imovel>
    {
         ICollection<Foto> GetByImagesImovelId(int id);
    }
}
