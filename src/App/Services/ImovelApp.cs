using System;
using System.Collections.Generic;
using ImovelBens.App.Contracts;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Entities;

namespace ImovelBens.App.Services
{
    public class ImovelApp: IImovelApp
    {

        private readonly IImovelService _imovelService;
        private readonly IFotoService _fotoService;

        public ImovelApp(IImovelService imovelService, IFotoService fotoService)
        {
            _imovelService = imovelService;
            _fotoService = fotoService;
        }

        public void Register(Imovel imovel)
        {
            try
            {
                _imovelService.Add(imovel);
                _imovelService.Commit();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }

        public void UpDate(Imovel imovel)
        {
            _imovelService.Update(imovel);
            _imovelService.Commit();
        }

        public void Delete(Imovel imovel)
        {
            try
            {
                _imovelService.Delete(imovel);
                _imovelService.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Imovel GetById(int id)
        {
            return _imovelService.GetById(id);
        }

        public IEnumerable<Imovel> GetAll()
        {
            return _imovelService.GetAll();
        }

        public void Commit()
        {
           _imovelService.Commit();
        }
    }
}
