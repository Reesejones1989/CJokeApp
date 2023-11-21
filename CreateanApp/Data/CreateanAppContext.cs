using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CreateanApp.Models;

namespace CreateanApp.Data
{
    public class CreateanAppContext : DbContext
    {
        public CreateanAppContext (DbContextOptions<CreateanAppContext> options)
            : base(options)
        {
        }

        public DbSet<CreateanApp.Models.Joke> Joke { get; set; } = default!;

        public DbSet<CreateanApp.Models.Schedule>? Schedule { get; set; }
    }
}
