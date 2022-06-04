using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryEFCore.DataContext
{
    public class StateImageDBContext : DbContext
    {
        public StateImageDBContext(DbContextOptions<StateImageDBContext> options) : base(options)
        {
        }

        public DbSet<StateImageModel> StateImage { get; set; }
    }
}
