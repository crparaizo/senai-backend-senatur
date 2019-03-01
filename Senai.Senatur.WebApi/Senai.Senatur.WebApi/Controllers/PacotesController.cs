using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (SenaturContext ctx = new SenaturContext())
                {
                    return Ok(ctx.Pacotes.ToList());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message + "Algo deu errado" });
            }
        }

        [HttpPost]
        public IActionResult Post(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message + "Algo deu errado" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put (Pacotes pacote, int id)
        {
            try
            {
                PacoteRepository.Alterar(pacote, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message + "Algo deu errado" });
            }
        }
    }
}