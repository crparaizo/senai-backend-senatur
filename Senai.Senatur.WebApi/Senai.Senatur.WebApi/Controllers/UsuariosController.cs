using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;

namespace Senai.Senatur.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (SenaturContext ctx = new SenaturContext())
                {
                    return Ok(ctx.Usuarios.ToList());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message + "Algo resoltou em um erro" });
            }
        }
    }
}