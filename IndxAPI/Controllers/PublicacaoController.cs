using AutoMapper;
using IndxAPI.Data;
using IndxAPI.Data.Dtos.Publicacao;
using IndxAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicacaoController : ControllerBase
    {
        private IndxContext _context;
        private IMapper _mapper;
        

        public PublicacaoController(IndxContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RecuperarPublicacoes()
        {
            return Ok(_context.Publicacoes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPublicacaoPorId(int id)
        {
            Publicacao publicacao = _context.Publicacoes.FirstOrDefault(p => p.Id == id);
            if(publicacao != null)
                return Ok(_mapper.Map<RecuperaPublicacaoDTO>(publicacao));

            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaPublicacao([FromBody] AdicionaPublicacaoDTO dto)
        {
            Publicacao publicacao = _mapper.Map<Publicacao>(dto);

            _context.Publicacoes.Add(publicacao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaPublicacaoPorId), new { Id = publicacao.Id }, publicacao);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPublicacao(int id, [FromBody] AtualizaPublicacaoDTO dto)
        {

            Publicacao publicacao = _context.Publicacoes.FirstOrDefault(p => p.Id == id);
            if (publicacao == null)
                return NotFound();

            _mapper.Map(dto, publicacao);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemovePublicacao(int id)
        {
            Publicacao publicacao = _context.Publicacoes.FirstOrDefault(p => p.Id == id);
            if (publicacao == null)
                return NotFound();

            _context.Remove(publicacao);

            _context.SaveChanges();

            return NoContent();
        }
    }
}
