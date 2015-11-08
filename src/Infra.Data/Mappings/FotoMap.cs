using System.Data.Entity.ModelConfiguration;
using ImovelBens.Domain.Entities;

namespace ImovelBens.Infra.Data.Mappings
{
    public class FotoMap : EntityTypeConfiguration<Foto>
    {
        public FotoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UrlFoto)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UrlThumb)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.ImovelId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Foto");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.UrlFoto).HasColumnName("UrlFoto");
            this.Property(t => t.UrlThumb).HasColumnName("UrlThumb");
            this.Property(t => t.ImovelId).HasColumnName("ImovelId");

            

        }
    }
}
