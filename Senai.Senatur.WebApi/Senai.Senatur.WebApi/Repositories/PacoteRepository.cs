using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        public void Alterar(Pacotes pacote, int id)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Pacotes.Find(id);

                ctx.Pacotes.Update(pacote);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Pacotes pacote)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Pacotes.Add(pacote);
                ctx.SaveChanges();                    
            }
        }

        public List<Pacotes> Listar()
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                return ctx.Pacotes.ToList();
            }
        }
    }
}