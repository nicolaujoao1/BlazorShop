using BlazorShop.API.Context;
using BlazorShop.API.Entities;
using BlazorShop.API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Repositories.Application
{
    public class ProdutoRepository:IProdutoRepository
    {

        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;    
        }

        public async Task<IEnumerable<Produto>> GetItemByCategoryAsync(int id)
        {
            var produto = await _context.Produtos.Include(c => c.Categoria).Where(p => p.CategoriaId == id).ToListAsync();
            return produto;
        }

        public async Task<Produto> GetItemByIdAsync(int id)
        {
            var produto =await _context.Produtos
                .Include(x => x.Categoria).FirstOrDefaultAsync(c => c.Id == id);
            return produto;

        }

        public async Task<IEnumerable<Produto>> GetItemsAsync()
        {
            var produto = await _context.Produtos.Include(c => c.Categoria) .ToListAsync();
            return produto;
        }
    }
}
