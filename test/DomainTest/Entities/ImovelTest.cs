using System;
using System.Collections.Generic;
using ImovelBens.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImovelBens.DomainTest.Entities
{
    [TestClass]
    public class ImovelTest
    {
        string _titulo;
        string _descricao;
        decimal _valor;
        string _regiao;
        double _lat;
        double _lng;
        ICollection<Foto> _fotos;
        private Corretor _corretor;
        private DateTime _dataLancamento;

        [TestInitialize]
        public void Initialize()
        {
            _titulo = "Titulo do Imóvel";
            _descricao = "Descrição do Imóvel";
            _valor = 200.00M;
            _regiao = "Região do Imóvel";
            _lat = 0;
            _lng = 0;
            _fotos = new List<Foto>();
            _corretor = new Corretor("Nome","11923456789", "11923456789","teste@teste.com.br");
            _dataLancamento = DateTime.Today;
        }

        [TestMethod]
        public void Quando_Eu_Criar_Um_Imovel()
        {
            //Arrange
            _fotos.Add(new Foto("Nome","UrlFoto","UrlThumb"));

            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert
            Assert.IsNotNull(imovel);
            Assert.AreEqual(_titulo, imovel.Titulo);
            Assert.AreEqual(_descricao, imovel.Descricao);
            Assert.AreEqual(_valor, imovel.Valor);
            Assert.AreEqual(_regiao, imovel.Regiao);
            Assert.AreEqual(_lat, imovel.Lat);
            Assert.AreEqual(_lng, imovel.Lng);
            Assert.IsTrue(_fotos.Count>0);
            Assert.IsNotNull(_corretor);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_o_Titulo_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _titulo = "";


            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);

            //Assert           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_a_Descricao_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _descricao = "";


            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_o_Valor_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _valor = 0;


            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_a_Regiao_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _regiao = "";


            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_Deve_Ter_ao_menos_uma_Foto()
        {
            //Arrange


            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert           
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Imovel_Corretor_Deve_ser_Obrigatorio()
        {
            //Arrange
            _corretor = null;

            //Action
            var imovel = new Imovel(_titulo, _descricao, _valor, _regiao, _lat, _lng, _fotos, _corretor, _dataLancamento);


            //Assert           
        }
    }
}
