using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Data;
using TestMappingEfCore.Models;
using TestMappingEfCore.Models.Converter;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Repository.Impl
{
    public class ClientRepositoryImpl : IClientRepository
    {
        private ClientContext clientContext { get; set; }
        public ClientRepositoryImpl(ClientContext clientContext)
        {
            this.clientContext = clientContext;
        }

        public async Task<ClientDAO> Create(ClientDAO clientDAO)
        {
            clientContext.Add(clientDAO);
            await clientContext.SaveChangesAsync();
            return clientDAO;
        }

        public async Task<ClientDAO> Delete(int id)
        {
            ClientDAO ClientDAO =clientContext.Clients.Find(id);
            clientContext.Remove(id);
            await clientContext.SaveChangesAsync();
            return ClientDAO;
        }

        public IQueryable<ClientDAO> GetAll()
        {
            return clientContext.Clients;
        }

        public async Task<ClientDAO> GetById(int id)
        {
            return await clientContext.Clients.FindAsync(id);           
        }

        public async Task<ClientDAO> Update( ClientDAO entity)
        {
            clientContext.Update(entity);
            await clientContext.SaveChangesAsync();
            return entity;
        }
    }
}
