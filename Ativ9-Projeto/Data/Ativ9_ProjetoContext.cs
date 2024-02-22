using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto;

namespace Ativ9_Projeto.Data
{
    public class Ativ9_ProjetoContext : DbContext
    {
        public Ativ9_ProjetoContext (DbContextOptions<Ativ9_ProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<Ativ9_Projeto.Viatura> Viatura { get; set; } = default!;
    }
}
