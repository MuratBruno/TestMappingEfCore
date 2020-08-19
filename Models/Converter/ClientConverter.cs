using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Models.Converter
{
    /// <summary>
    /// Cette classe permer d'effectuer des conversion entre les classes ClientDAO, ClientDBO et ClientDTO
    /// </summary>
    public class ClientConverter : IConverter<ClientDAO, ClientDBO, ClientDTO>
    {
        //Pattern singleton
        private static ClientConverter clientConverter;
        public static ClientConverter getConverter()
        {
            if (clientConverter == null)
            {
                clientConverter = new ClientConverter();
            }
            return clientConverter;
        }

        //Constructeur privé
        private ClientConverter()
        {

        }



        public ClientDBO fromDAOTodBO(ClientDAO dAO)
        {
            ClientDBO clientDBO = new ClientDBO();
            clientDBO.id = dAO.id;
            return clientDBO;
        }

        public ClientDTO fromDAOTodTO(ClientDAO dAO)
        {
            ClientDBO clientDBO =fromDAOTodBO(dAO);
            ClientDTO ClientDTO = fromDBOTodTO(clientDBO);
            return ClientDTO;
        }

        public ClientDAO fromDBOTodAO(ClientDBO dBO)
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.id = dBO.id;
            return clientDAO;
        }

    

        public ClientDTO fromDBOTodTO(ClientDBO dBO)
        {
            ClientDTO ClientDTO = new ClientDTO();
            ClientDTO.id = dBO.id;
            return ClientDTO;
        }

        public ClientDAO fromDTOTodAO(ClientDTO dTO)
        {
            ClientDBO clientDBO = fromDTOTodBO(dTO);
            ClientDAO ClientDAO = fromDBOTodAO(clientDBO);
            return ClientDAO;
        }

        public ClientDBO fromDTOTodBO(ClientDTO dTO)
        {
            ClientDBO clientDBO = new ClientDBO();
            clientDBO.id = dTO.id;
            return clientDBO;
        }


    }
}
