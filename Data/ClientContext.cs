using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models;
using TestMappingEfCore.Models.DonneeDAO;

namespace TestMappingEfCore.Data
{
    public class ClientContext: DbContext
    {
        public ClientContext()
        {

        }

        //Pour les tests unitaires
        public static ClientContext getContext()
        {
            return new ClientContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=db;Database=master;User=sa;Password=toTO123456!&@;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<ClientDAO> Clients { get; set; }
    }
}
