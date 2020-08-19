using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Models.MetierDBO;

namespace TestMappingEfCore.Models.DonneeDAO
{

    /// <summary>
    /// Classe du client tel qu'il sera enregistré en BDD
    /// </summary>

    [Table("Client")]
    public class ClientDAO 
    {
        [Key]
        public int id { get; set; }

    }
}
