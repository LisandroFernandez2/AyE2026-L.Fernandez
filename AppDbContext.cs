using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Base_de_Datos
{
    internal class AppDbContext : DbContext
    {
        // le pongo el nombre de la tabla para organizarme mejor y no perderme
        public DbSet<Pokemon> pokemon => Set<Pokemon>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "port=3307;Database=pokedex;Uid=root;Server=localhost;pwd=;";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

