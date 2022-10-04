using BlazorShop.Models.DTOs;

namespace BlazorShop.UI.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDto>> GetItems();
    }
}
