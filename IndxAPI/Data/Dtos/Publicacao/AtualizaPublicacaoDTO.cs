using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndxAPI.Data.Dtos.Publicacao
{
    public class AtualizaPublicacaoDTO
    {
        [Required]
        public String Nome { get; set; }
    }
}
