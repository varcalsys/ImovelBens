using System.Collections.Generic;
using ImovelBens.Domain.Entities;

namespace ImovelBens.App.Contracts
{
    public interface IFotoApp: IAppBase<Foto>
    {
        void Register(Foto entity);

        
    }
}
