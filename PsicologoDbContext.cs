using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PjMuriloZarpelon.Models;

namespace PjMuriloZarpelon.Data
{
    public class PsicologoDbContext : IdentityDbContext<Psicologo>
    {
        public PsicologoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Psicologo> PsicologoSet { get; set; }
    }
}
