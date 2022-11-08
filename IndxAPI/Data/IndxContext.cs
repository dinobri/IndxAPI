using IndxAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndxAPI.Data
{
    public class IndxContext : DbContext
    {
        public IndxContext(DbContextOptions<IndxContext> opt) : base(opt)
        {

        }

        public DbSet<Publicacao> Publicacoes { get; set; }
    }
}
