using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImovelBens.Domain.Entities
{
    public class Corretor
    {

        #region props

        public int CorretorId { get; private set; }
        public string Nome { get; private set; }
        public string Celular { get; private set; }
        public string Whatsapp { get; private set; }
        public string Email { get; private set; }
      

        #endregion


        #region ctors

        protected Corretor()
        {

        }

        public Corretor(string nome, string celular, string whatsapp, string email)
        {
            if(string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Campo obrigatório");
            if (string.IsNullOrWhiteSpace(celular))
                throw new ArgumentException("Campo obrigatório");
            if (string.IsNullOrWhiteSpace(whatsapp))
                throw new ArgumentException("Campo obrigatório");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Campo obrigatório");

            Nome = nome;
            Celular = celular;
            Whatsapp = whatsapp;
            Email = email;
        }

        public Corretor(int corretorId, string nome, string celular, string whatsapp, string email)
            : this(nome, celular, whatsapp, email)
        {
            CorretorId = corretorId;
        }

        #endregion

    }
}
