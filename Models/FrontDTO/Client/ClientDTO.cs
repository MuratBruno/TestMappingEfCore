using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Models.DonneeDAO
{
    /// <summary>
    /// Classe du client tel qu'il sera utiisée par la partie front.
    /// D'autre DTO représentant le client peuvent exister selon l'affichage voulu, exemple : ClientDetailsDTO.
    /// </summary>
    public class ClientDTO 
    {
        public int id { get; set; }

        //Nombre d'achat effectué par le client, ce nombre ne servant que la partie front, il n'apparait que dans le DTO
        public int nbAchat { get; set; }
    }
}
