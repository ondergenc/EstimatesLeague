using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EstimatesLeague.Entity
{
    public class ELDContext : IdentityDbContext<ELDUser, IdentityRole<Guid>, Guid>
    {
        public ELDContext(DbContextOptions options) : base(options)
        {
        }
    }
}
