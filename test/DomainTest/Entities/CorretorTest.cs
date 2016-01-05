using System;
using ImovelBens.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImovelBens.DomainTest.Entities
{
    [TestClass]
    public class CorretorTest
    {
        string _nome;
        string _celular;
        string _whatsapp;
        string _email;

        [TestInitialize]
        public void Initialize()
        {
             _nome = "Nome do Corretor";
             _celular = "11923456789";
             _whatsapp = "11923456789";
             _email = "teste@teste.com.br";
        }


        [TestMethod]
        public void Quando_Eu_Criar_Um_Corretor()
        {
            //Arrange
            

            //Action
            var corretor = new Corretor(_nome, _celular, _whatsapp, _email);

            //Assert
            Assert.IsNotNull(corretor);
            Assert.AreEqual(_nome, corretor.Nome);
            Assert.AreEqual(_celular, corretor.Celular);
            Assert.AreEqual(_whatsapp, corretor.Whatsapp);
            Assert.AreEqual(_email, corretor.Email);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Corretor_O_Nome_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _nome = "";

            //Action
            var corretor = new Corretor(_nome, _celular, _whatsapp, _email);

            //Assert
          
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Corretor_O_Celular_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _celular = "";

            //Action
            var corretor = new Corretor(_nome, _celular, _whatsapp, _email);

            //Assert

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Corretor_O_Whatsapp_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _whatsapp = "";

            //Action
            var corretor = new Corretor(_nome, _celular, _whatsapp, _email);

            //Assert

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Eu_Criar_Um_Corretor_O_Email_Deve_Ser_Obrigatorio()
        {
            //Arrange
            _email = "";

            //Action
            var corretor = new Corretor(_nome, _celular, _whatsapp, _email);

            //Assert

        }
    }

}
