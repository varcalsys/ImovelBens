using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImovelBens.Domain.Entities
{
    public class Foto
    {

        #region props

        public int FotoId { get; private set; }
        public string Nome { get; private set; }
        public string UrlFoto { get; private set; }
        public string UrlThumb { get; private set; }
        public int ImovelId { get; private set; }


        #endregion


        #region ctors

        protected Foto()
        {

        }

        public Foto(string nome, string urlFoto, string urlThumb)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Campo obrigatório");
            if (string.IsNullOrWhiteSpace(urlFoto))
                throw new ArgumentException("Campo obrigatório");
            if (string.IsNullOrWhiteSpace(urlThumb))
                throw new ArgumentException("Campo obrigatório");

            Nome = nome;
            UrlFoto = urlFoto;
            UrlThumb = urlThumb;
        }

        public Foto(int fotoId, string nome, string urlFoto, string urlThumb)
            : this(nome, urlFoto, urlThumb)
        {
            if(fotoId<=0)
                throw new ArgumentException("Campo obrigatório");

            FotoId = fotoId;
        }

        #endregion

    }
}
