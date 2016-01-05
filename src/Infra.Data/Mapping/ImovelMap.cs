using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Infra.Data.Mapping
{
    public class ImovelMap: EntityTypeConfiguration<Imovel>
    {
        public ImovelMap()
        {
            ToTable("Imovel");

            HasKey(p => p.ImovelId);

            HasMany(p => p.Fotos)
                .WithRequired()
                .HasForeignKey(p => p.ImovelId);

            HasRequired(p => p.Corretor)
                .WithMany()
                .HasForeignKey(x => x.CorretorId);

            Property(p => p.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("text")
                .HasMaxLength(1000)
                .IsRequired();
            Property(p => p.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal")
                .HasPrecision(11,2)
                .IsRequired();
            Property(p => p.Regiao)
                .HasColumnName("Regiao")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.Lat)
                .HasColumnName("Lat")
                .IsRequired();
            Property(p => p.Lng)
               .HasColumnName("Lng")
               .IsRequired();
            Property(p => p.CorretorId)
               .HasColumnName("CorretorId")
               .HasColumnType("int")
               .IsRequired();
            Property(p => p.DataLancamento)
               .HasColumnName("DataLancamento")
               .HasColumnType("date")
               .IsOptional();
        }
    }
}
