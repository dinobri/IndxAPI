using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndxAPI.Models
{
    public class Publicacao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        
    }
}
