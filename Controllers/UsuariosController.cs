using System;
using Microsoft.AspNetCore.Mvc;

namespace RestricaoDeTiposRotas.Controllers
{
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet("/usuarios/{nomeUsuario}")]
        public ActionResult GetByUsername(string nomeUsuario) => Ok($"Usuário com nome de {nomeUsuario}");

        [HttpGet("/usuarios/{id:guid}")]
        public ActionResult GetById(Guid id) => Ok($"Usuário com ID {id}");
    }
}