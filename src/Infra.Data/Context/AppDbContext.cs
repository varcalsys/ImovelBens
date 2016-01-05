using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ImovelBens.Domain.Entities;
using ImovelBens.Infra.Data.Mapping;

namespace ImovelBens.Infra.Data.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext():base("Name=ImovelBensConnection")
        {
             
        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Foto> Fotos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(x=>x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x=>x.HasMaxLength(50));

            modelBuilder.Configurations.Add(new ImovelMap());
            modelBuilder.Configurations.Add(new CorretorMap());
            modelBuilder.Configurations.Add(new FotoMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
