using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Services
{
    /// <summary>
    /// Le service client s'occupe toute oppération intermédiare entre la reception par le controller et l'enregistrement en bdd
    /// </summary>
    public interface IClientService
    {
        public IQueryable<ClientDTO> GetAll();

        public ClientDTO GetById(int id);

        public ClientDTO Create(ClientDTO entity);

        public ClientDTO Update(ClientDTO entity);

        public ClientDTO Delete(int id);
    }
}
