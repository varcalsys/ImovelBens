using ImovelBens.App.Contracts;
using ImovelBens.App.Services;
using ImovelBens.CrossCutting.Identity.Configuration;
using ImovelBens.CrossCutting.Identity.Context;
using ImovelBens.CrossCutting.Identity.Models;
using ImovelBens.Domain.Contracts.Repositories;
using ImovelBens.Domain.Contracts.Services;
using ImovelBens.Domain.Services;
using ImovelBens.Infra.Data.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace ImovelBens.CrossCutting.Ioc
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);


            container.Register<IImovelApp, ImovelApp>(Lifestyle.Scoped);
            container.Register<IFotoApp, FotoApp>(Lifestyle.Scoped);

            container.Register(typeof(IServiceBase<>),typeof(ServiceBase<>));
            container.Register<IImovelService, ImovelService>(Lifestyle.Scoped);
            container.Register<IFotoService, FotoService>(Lifestyle.Scoped);

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IImovelRepository, ImovelRepository>(Lifestyle.Scoped);
            container.Register<IFotoRepository, FotoRepository>(Lifestyle.Scoped);

        }
    }
}
