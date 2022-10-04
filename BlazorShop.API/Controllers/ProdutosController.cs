using BlazorShop.API.Mappings;
using BlazorShop.API.Repositories.Contracts;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository; 
        public ProdutosController(IProdutoRepository produtoRepository)=>_produtoRepository = produtoRepository;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItems()
        {
            try
            {
                var produtos = await _produtoRepository.GetItemsAsync();
                return produtos is null ? NotFound():Ok(produtos.ConverterProdutoParaDto());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Erro ao acessar a base de dado");
            }
        }

    }
}
