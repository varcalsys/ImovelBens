using System;
using ImovelBens.CrossCutting.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ImovelBens.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("ImovelBensConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}