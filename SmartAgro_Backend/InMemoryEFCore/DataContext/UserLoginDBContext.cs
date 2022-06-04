using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryEFCore.DataContext
{
    public class UserLoginDBContext : DbContext
    {
        public UserLoginDBContext(DbContextOptions<UserLoginDBContext> options) : base(options)
        {
        }

        public DbSet<UserLoginModel> UserLogin { get; set; }
    }
}
