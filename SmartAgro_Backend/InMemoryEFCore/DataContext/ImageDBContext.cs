using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryEFCore.DataContext
{
    public class ImageDBContext : DbContext
    {
        public ImageDBContext(DbContextOptions<ImageDBContext> options) : base(options)
        {
        }

        public DbSet<ImageModel> StateImage { get; set; }
        public DbSet<ImageModel> CultivarsImage { get; set; }
    }
}
