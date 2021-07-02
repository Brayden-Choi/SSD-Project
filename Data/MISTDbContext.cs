using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MIST.Models;

namespace MIST.Data
{
    public class MISTDbContext : IdentityDbContext
    {
        public MISTDbContext(DbContextOptions<MISTDbContext> options)
            : base(options)
        {
        }
        public DbSet<MIST.Models.Game> Game { get; set; }
    }
}
