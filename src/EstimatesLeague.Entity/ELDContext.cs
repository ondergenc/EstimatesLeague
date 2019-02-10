using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EstimatesLeague.Entity
{
    public class ELDContext : IdentityDbContext<ELDUser>
    {
        public ELDContext(DbContextOptions options) : base(options)
        {
        }
    }
}
