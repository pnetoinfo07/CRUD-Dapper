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
        [HttpGet("Listar-Produtos")]
        public List<Produto> ListarProdutos()
        {
         return _repository.ListarProdutos();
        }

        [HttpPost("Adicionar-Produtos")]
        public void AdicionarProduto(Produto p)
        {
            _repository.AdicionarContrib(p);
        }

        [HttpPut("Editar-Produtos")]
        public void EditarProduto(Produto p)
        {
            _repository.Editar(p);
        }

        [HttpDelete("Remover-Produtos")]
        public void RemoverProduto(int id)
        {
            _repository.Delete(id);
        }

    }
}