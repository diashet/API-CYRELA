using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPICyrela.Models;

namespace WebAPICyrela.Repository.Context
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Assistencia> Assistencia { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseOracle(config.GetConnectionString("FiapSmartCityConnection"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
