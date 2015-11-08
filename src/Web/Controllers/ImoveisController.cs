using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using CrossCutting.Util.Common;
using ImovelBens.App.Contracts;
using ImovelBens.Domain.Entities;
using ImovelBens.Web.Models;

namespace ImovelBens.Web.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly IImovelApp _imovelApp;
        private readonly IFotoApp _fotoApp;

        public ImoveisController(IImovelApp imovelApp, IFotoApp fotoApp)
        {
            _imovelApp = imovelApp;
            _fotoApp = fotoApp;
        }

        // GET: Imoveis
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Pesquisar()
        {
            IEnumerable<Imovel> imoveis = null;

            if (TempData["Imoveis"] == null)
            {
                imoveis = _imovelApp.GetAll();
                return View(imoveis);
            }

            imoveis = TempData["Imoveis"] as IEnumerable<Imovel>;
            return View(imoveis);
        }


        public ActionResult Detalhes(int id)
        {
            var imovel = _imovelApp.GetById(id); 
            ICollection<Imovel> imoveis = new List<Imovel>();  
            imoveis.Add(imovel);  
            ViewBag.Imoveis = imoveis;
            return View(imovel);
        }

        [Authorize]
        public ActionResult Registrar()
        {
            ViewBag.Imoveis = _imovelApp.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registrar(ImovelViewModel model)
        {
            var fotos = new List<Foto>();

            try
            {
                if (!ModelState.IsValid)
                {

                    return View(model);
                }


                var imovel = new Imovel
                {
                    Title = model.Title,
                    Description = model.Description,
                    Type = model.Type,
                    Price = model.Price,
                    Address = model.Address,
                    Bathrooms = model.Bathrooms,
                    Bedrooms = model.Bedrooms,
                    Area = model.Area,
                    Lat = model.Lat,
                    Lng = model.Lng,
                    Garage = model.Garage,
                    SecuritySystem = model.SecuritySystem,
                    AirConditioning = model.AirConditioning,
                    Balcony = model.Balcony,
                    OutdoorPool = model.OutdoorPool,
                    Internet = model.Internet,
                    Heating = model.Heating,
                    TvCable = model.TvCable,
                    Garden = model.Garden,
                    Telephone = model.Telephone,
                    FirePlace = model.FirePlace,

                };


                fotos = Helper.LoadFiles(model.Images, Server.MapPath("~/"));
                imovel.Image = fotos[0].Nome;

                imovel.Fotos = fotos;

                _imovelApp.Register(imovel);

                _imovelApp.Commit();

                return RedirectToAction("Registrar");
            }
            catch (Exception)
            {
                ViewBag.Message = "Erro ao registrar imóvel";
                Helper.DeleteFiles(fotos);
                return RedirectToAction("Registrar");
            }
        }
    }
}