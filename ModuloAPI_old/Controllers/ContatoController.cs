using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

//Criando um controle que cria um registro no Banco de Dados pela API
        [HttpPost]
        public IActionResult Create(Contato contato) 
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

//Criando um controle que consulta um registro no Banco de Dados pela API
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null){
                return NotFound();
            }
            return Ok(contato);

        }
    }
}