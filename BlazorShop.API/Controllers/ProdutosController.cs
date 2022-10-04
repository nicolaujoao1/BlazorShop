using BlazorShop.API.Mappings;
using BlazorShop.API.Repositories.Contracts;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutosController(IProdutoRepository produtoRepository) => _produtoRepository = produtoRepository;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItems()
        {
            try
            {
                var produtos = await _produtoRepository.GetItemsAsync();

                return produtos is null ? NotFound() : Ok(produtos.ConverterProdutoParaDto());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dado");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoDto>> GetItem(int id)
        {
            try
            {
                var produto = await _produtoRepository.GetItemByIdAsync(id);

                return produto is null ? NotFound("Produto não localizado") : Ok(produto.ConverterProdutoParaDto());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dado");
            }

             
        }
        [HttpGet]
        [Route("Items-Categoria/{categoriaId}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>>GetItemsPorCategoria(int categoriaId)
        {
            try
            {
                var produtos = await _produtoRepository.GetItemByCategoryAsync(categoriaId);
                var produtosDto=produtos.ConverterProdutoParaDto();
                return Ok(produtosDto);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dado");
            }
        }

    }
}
