using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.FrontDTO.Achat;

namespace TestMappingEfCore.Models.FrontDTO
{
    public class ClientDetailsDTO
    {
        public int id { get; set; }

        //Achats effectués par le client, cette liste n'apparait que lorque l'on consulte la page de détail du client
        public AchatDTO[] achats { get; set; }
    }
}
