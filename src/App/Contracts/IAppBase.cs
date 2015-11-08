using System.Collections.Generic;

namespace ImovelBens.App.Contracts
{
    public interface IAppBase<T> where T: class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Commit();
       
    }
}
