using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> Listar()
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}