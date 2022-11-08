using AutoMapper;
using IndxAPI.Data.Dtos.Publicacao;
using IndxAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndxAPI.Profiles
{
    public class PublicacaoProfile : Profile
    {
        public PublicacaoProfile()
        {
            CreateMap<AdicionaPublicacaoDTO, Publicacao>();
            CreateMap<Publicacao, RecuperaPublicacaoDTO>();
            CreateMap<AtualizaPublicacaoDTO, Publicacao>();
        }
    }
}
