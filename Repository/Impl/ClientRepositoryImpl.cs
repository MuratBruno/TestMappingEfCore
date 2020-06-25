using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Data;
using TestMappingEfCore.Models;

namespace TestMappingEfCore.Repository.Impl
{
    public class ClientRepositoryImpl : ClientRepository
    {
        private ClientContext clientContext { get; set; }
        public ClientRepositoryImpl(ClientContext clientContext)
        {
            this.clientContext = clientContext;
        }

        public async Task<Client> Create(Client client)
        {
            clientContext.Add(client);
            await clientContext.SaveChangesAsync();
            return client;
        }

        public async Task<Client> Delete(int id)
        {
            Client client =clientContext.Clients.Find(id);
            clientContext.Remove(id);
            await clientContext.SaveChangesAsync();
            return client;
        }

        public IQueryable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Client> GetById(int id)
        {
            return  clientContext.Clients.Find(id);
        }

        public async Task<Client> Update(int id, Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
