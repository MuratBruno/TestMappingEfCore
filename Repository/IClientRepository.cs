using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Repository
{
    public interface IClientRepository
    {
        public IQueryable<ClientDAO> GetAll();

        public  Task<ClientDAO> GetById(int id);

        public  Task<ClientDAO> Create(ClientDAO entity);

        public  Task<ClientDAO> Update(ClientDAO entity);

        public  Task<ClientDAO> Delete(int id);
    }
}
