using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.Converter;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;
using TestMappingEfCore.Repository;
using TestMappingEfCore.Repository.Impl;

namespace TestMappingEfCore.Services.Impl
{
    /// <summary>
    /// Le service client s'occupe toute oppération intermédiare entre la reception par le controller et l'enregistrement en bdd
    /// </summary>
    public class ClientServiceImpl : IClientService
    {
        IClientRepository clientRepository;

        ClientConverter converter=ClientConverter.getConverter();
        public ClientServiceImpl(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        //Pour les tests unitaires
        public static ClientServiceImpl getClientServiceImpl()
        {
            return new ClientServiceImpl(ClientRepositoryImpl.getRepositoryImpl());
        }
        public ClientDTO Create(ClientDTO entity)
        {
            ClientDAO clientDAO = converter.fromDTOTodAO(entity);
            ClientDAO resultClientDAO = clientRepository.Create(clientDAO).Result;
            ClientDTO resultClientDTO = converter.fromDAOTodTO(resultClientDAO);
            return resultClientDTO;
        }

        public ClientDTO Delete(int id)
        {
            ClientDAO resultClientDAO = clientRepository.Delete(id).Result;
            ClientDTO resultClientDTO = converter.fromDAOTodTO(resultClientDAO);
            return resultClientDTO;
        }

        public IQueryable<ClientDTO> GetAll()
        {
            IQueryable<ClientDAO> resultClientDAOQueryable = clientRepository.GetAll();
            List<ClientDTO> resultClientDTOList = new List<ClientDTO>();
            foreach (ClientDAO clientDAO in resultClientDAOQueryable)
            {
                ClientDTO resultClientDTO = converter.fromDAOTodTO(clientDAO);
                resultClientDTOList.Add(resultClientDTO);
            }
            return resultClientDTOList.AsQueryable<ClientDTO>();
        }

        public ClientDTO GetById(int id)
        {
            ClientDAO resultClientDAO = clientRepository.GetById(id).Result;
            ClientDTO resultClientDTO = converter.fromDAOTodTO(resultClientDAO);
            return resultClientDTO;
        }

        public ClientDTO Update( ClientDTO entity)
        {
            ClientDAO clientDAO = converter.fromDTOTodAO(entity);
            ClientDAO resultClientDAO = clientRepository.Update(clientDAO).Result;
            ClientDTO resultClientDTO = converter.fromDAOTodTO(resultClientDAO);
            return resultClientDTO;
        }
    }
}
