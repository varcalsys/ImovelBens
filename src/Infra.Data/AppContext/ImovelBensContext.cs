using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ImovelBens.Domain.Entities;


namespace ImovelBens.Infra.Data.AppContext
{
    public class ImovelBensContext : DbContext
    {
         public ImovelBensContext()
            : base("Name=ImovelBensConnection")
         {
             Configuration.ProxyCreationEnabled = false;
             Configuration.LazyLoadingEnabled = false;
         }

       public DbSet<Foto> Fotos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {         

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Configurations.Add(new FotoMap());
            //modelBuilder.Configurations.Add(new ImovelMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
