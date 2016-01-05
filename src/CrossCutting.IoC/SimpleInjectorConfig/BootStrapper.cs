using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Services;
using ImovelBens.Infra.Data.Context;
using ImovelBens.Infra.Data.Repositories;
using SimpleInjector;

namespace ImovelBens.CrossCutting.IoC.SimpleInjectorConfig
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            //container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            //container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            //container.Register<ApplicationSignInManager>(Lifestyle.Scoped);


            //Apllication Layer


            //Domain Layer
            container.Register<IImovelDomainService, ImovelDomainService>(Lifestyle.Scoped);
            container.Register<ICorretorDomainService, CorretoDomainService>(Lifestyle.Scoped);
            container.Register<IFotoDomainService, FotoDomainService>(Lifestyle.Scoped);

            //Repository Layer
            container.Register<IImovelRepository, ImovelRepository>(Lifestyle.Scoped);
            container.Register<ICorretorRepository, CorretorRepository>(Lifestyle.Scoped);
            container.Register<IFotoRepository, FotoRepository>(Lifestyle.Scoped);

            //Context
            container.Register<AppDbContext, AppDbContext>(Lifestyle.Scoped);
        }
    }
}
