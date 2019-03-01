using Senai.Senatur.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuarios> Listar();

        Usuarios BuscarPorEmailSenha(string email, string senha);
    }
}