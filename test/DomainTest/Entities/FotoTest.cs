using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImovelBens.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImovelBens.DomainTest.Entities
{
    [TestClass]
    public class FotoTest
    {

        string _nome;
        string _urlFoto;
        string _urlThumb;

        [TestInitialize]
        public void Initialize()
        {
            _nome = "Nome Foto";
            _urlFoto = "Url da Foto";
            _urlThumb = "UrlThumb";
        }

        [TestMethod]
        public void Quando_Eu_Criar_Uma_Foto()
        {
            //Arrange
            


            //Action
            var foto = new Foto(_nome, _urlFoto, _urlThumb);

            //Assert
            Assert.IsNotNull(foto);
            Assert.AreEqual(_nome, foto.Nome);
            Assert.AreEqual(_urlFoto, foto.UrlFoto);
            Assert.AreEqual(_urlThumb, foto.UrlThumb);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Uma_Foto_o_Nome_Deve_Ser_Obrigatorio()
        {
            //Arrange

            _nome = string.Empty;

            //Action
            var foto = new Foto(_nome, _urlFoto, _urlThumb);

            //Assert
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Uma_Foto_a_Url_da_Foto_Deve_Ser_Obrigatoria()
        {
            //Arrange

            _urlFoto = string.Empty;

            //Action
            var foto = new Foto(_nome, _urlFoto, _urlThumb);

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Uma_Foto_a_Url_da_Thumb_Deve_Ser_Obrigatoria()
        {
            //Arrange

            _urlThumb = string.Empty;

            //Action
            var foto = new Foto(_nome, _urlFoto, _urlThumb);

            //Assert

        }
    }
}
