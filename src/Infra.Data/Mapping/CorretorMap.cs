using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Infra.Data.Mapping
{
    public class CorretorMap: EntityTypeConfiguration<Corretor>
    {
        public CorretorMap()
        {
            ToTable("Corretor");

            HasKey(p => p.CorretorId);

        
            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.Celular)
                .HasColumnName("Celular")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();
            Property(p => p.Whatsapp)
                .HasColumnName("Whatsapp")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired();
            Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            

        }
    }
}
