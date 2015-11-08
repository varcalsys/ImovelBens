using ImovelBens.Domain.Entities;

namespace ImovelBens.App.Contracts
{
    public interface IImovelApp: IAppBase<Imovel>
    {

        void Register(Imovel imovel);
        void UpDate(Imovel imovel);
        void Delete(Imovel imovel);

    }
}
