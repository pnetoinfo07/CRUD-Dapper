using Microsoft.AspNetCore.Mvc;

namespace CRUD_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _repository;
        public ProdutoController(IConfiguration configuration)
        {
            _repository = new ProdutoRepository(configuration);
        }
        [HttpPost("Adicionar-dapper")]
        public void Adicionar(Produto p)
        {
         _repository.Adicionar(p);
        }

        [HttpPost("Adicionar-dapper-cntrib")]
        public void AdicionarProduto(Produto p)
        {
            _repository.AdicionarContrib(p);
        }

    }
}