using System;
using System.Collections.Generic;


namespace ImovelBens.Domain.Entities
{
    public class Imovel
    {
        #region props

        public int ImovelId { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public string Regiao { get; private set; }
        public double Lat { get; private set; }
        public double Lng { get; private set; }
        public int CorretorId { get; private set; }
        public DateTime DataLancamento { get; private set; }

        public virtual ICollection<Foto> Fotos { get; private set; }
        public virtual Corretor Corretor{ get; private set; }
           
        #endregion

        #region ctors

        protected Imovel()
        {
            Fotos = new List<Foto>();
        }

        public Imovel(int imovelId, string titulo, string descricao, decimal valor, string regiao, double lat, double lng, ICollection<Foto> fotos, Corretor corretor, DateTime dataLancamento)
            : this(titulo, descricao, valor, regiao, lat, lng, fotos,corretor, dataLancamento)
        {
            if (imovelId <= 0)
                throw new ArgumentException("Campo obrigátorio");
            ImovelId = imovelId;
        }

        public Imovel(string titulo, string descricao, decimal valor, string regiao, double lat, double lng, ICollection<Foto> fotos, Corretor corretor, DateTime dataLancamento)
            : this()
        {

            if(string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("Titulo é obrigátorio");
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("Descrição é obrigátoria");
            if (valor<=0)
                throw new ArgumentException("Valor é obrigátorio");
            if (string.IsNullOrWhiteSpace(regiao))
                throw new ArgumentException("Região é obrigátoria");
            if(fotos.Count<1)
                throw new ArgumentException("Foto é obrigatória");
            if(corretor == null)
                throw new ArgumentException("Corretor é obrigatório");

            Titulo = titulo;
            Descricao = descricao;
            Valor = valor;
            Regiao = regiao;
            Lat = lat;
            Lng = lng;
            Fotos = fotos;
            CorretorId = corretor.CorretorId;
            DataLancamento = dataLancamento;
            Corretor = corretor;
        }


        #endregion
    }
}
