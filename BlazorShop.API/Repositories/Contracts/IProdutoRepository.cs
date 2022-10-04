using BlazorShop.API.Entities;

namespace BlazorShop.API.Repositories.Contracts
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItemsAsync();
        Task<Produto> GetItemByIdAsync(int id);
        Task<IEnumerable<Produto>> GetItemByCategoryAsync(int id);

    }
}
