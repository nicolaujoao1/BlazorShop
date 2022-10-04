using BlazorShop.Models.DTOs;
using System.Net.Http.Json;

namespace BlazorShop.UI.Services
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoService(HttpClient httpClient, ILogger<ProdutoService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public HttpClient _httpClient { get; set; }
        public ILogger<ProdutoService> _logger { get; set; }    
        public async Task<IEnumerable<ProdutoDto>> GetItems()
        {
            try
            {
                var produtosDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProdutoDto>>("api/produtos");
                return produtosDto;
            }
            catch (Exception)
            {
                _logger.LogError("Erro ao acessar produtos : api/produtos");
                throw;
            }
            
        }
    }
}
