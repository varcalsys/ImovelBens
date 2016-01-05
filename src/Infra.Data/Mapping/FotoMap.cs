using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Infra.Data.Mapping
{
    public class FotoMap: EntityTypeConfiguration<Foto>
    {
        public FotoMap()
        {
            ToTable("Foto");

            HasKey(p => p.FotoId);

            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            Property(p => p.UrlFoto)
                .HasColumnName("UrlFoto")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
            Property(p => p.UrlThumb)
                .HasColumnName("UrlThumb")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
