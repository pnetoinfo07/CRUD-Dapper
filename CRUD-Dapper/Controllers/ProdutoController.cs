using AutoMapper;
using CRUD_Dapper.DTOs.Produto;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _repository;
        private readonly IMapper _mapper;
        public ProdutoController(IMapper mapper, IConfiguration configuration)
        {
            _repository = new ProdutoRepository(configuration);
            _mapper = mapper;
        }
        [HttpGet("Listar-Produtos")]
        public List<Produto> ListarProdutos()
        {
            return _repository.ListarProdutos();
        }

        [HttpPost("Adicionar-Produtos")]
        public void AdicionarProduto(CreateProdutoDTO p)
        {
            Produto produto = _mapper.Map<Produto>(p);
            _repository.AdicionarContrib(produto);
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