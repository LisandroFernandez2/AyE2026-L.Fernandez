using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Pokemon> pokedex => Set<Pokemon>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;port=3007;Database=pokedex;Uid=root;pwd=;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
