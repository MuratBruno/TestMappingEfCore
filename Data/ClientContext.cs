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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestMappingEfCoreDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<ClientDAO> Clients { get; set; }
    }
}
