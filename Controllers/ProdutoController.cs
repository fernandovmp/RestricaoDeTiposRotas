using Microsoft.AspNetCore.Mvc;

namespace RestricaoDeTiposRotas.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("sem-restricao/produtos/{id}")]
        public ActionResult GetById(int id) => Ok($"Produto de ID {id}");

        [HttpGet("produtos/{id:int}")]
        public ActionResult GetById2(int id) => Ok($"Produto de ID {id}");
    }
}