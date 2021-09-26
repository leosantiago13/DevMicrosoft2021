using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        // POST:api/produto/create
        [HttpPost]
        [Route("create")]
        public Produto Post(Produto produto)
        {
            return produto;
        }
    }
}