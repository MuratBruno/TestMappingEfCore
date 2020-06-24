using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models;

namespace TestMappingEfCore.Repository
{
    public interface ClientRepository
    {
        public IQueryable<Client> GetAll();

        public  Task<Client> GetById(int id);

        public  Task<Client> Create(Client entity);

        public  Task<Client> Update(int id, Client entity);

        public  Task<Client> Delete(int id);
    }
}
