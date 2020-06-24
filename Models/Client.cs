using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestMappingEfCore.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int key { get; set; }
    }
}
