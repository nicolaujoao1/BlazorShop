using BlazorShop.API.Entities;
using BlazorShop.Models.DTOs;

namespace BlazorShop.API.Mappings
{
    public static class MappingDtos
    {
        public static IEnumerable<CategoriaDto> ConverterCategoriaParaDto(this IEnumerable<Categoria> categorias)
        {
            return 
                (
                    from categoria in categorias
                    select new CategoriaDto { Id=categoria.Id,Nome=categoria.Nome,IconCss=categoria.IconCss}
                ).ToList();
        }
        public static IEnumerable<ProdutoDto> ConverterProdutoParaDto(this IEnumerable<Produto> produtos)
        {
            return (from produto in produtos
                    select new ProdutoDto
                    {
                        Id = produto.Id,
                        Name = produto.Nome,
                        Descricao = produto.Descricao,
                        ImageUrl = produto.ImagemUrl,
                        Preco = produto.Preco,
                        Quantidade = produto.Quantidade,
                        CategoriaId = produto.CategoriaId,
                        CategoriaNome = produto.Categoria.Nome
                    }).ToList();
        }
        public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItensParaDto(
            this IEnumerable<CarrinhoItem>carrinhoItems,IEnumerable<Produto> produtos) 
        {
            return (from carrinhoItem in carrinhoItems
                    join produto in produtos 
                    on carrinhoItem.ProdutoId equals produto.Id
                    select new CarrinhoItemDto
                    {
                        Id=carrinhoItem.Id, 
                        ProdutoId = produto.Id, 
                        ProdutoNome=produto.Nome,
                        ProdutoDescricao=produto.Descricao,
                        ProdutoImagemURL=produto.ImagemUrl,                        
                        Preco=produto.Preco,
                        CarrinhoId=carrinhoItem.CarrinhoId,
                        Quantidade=produto.Quantidade,
                        PrecoTotal=produto.Preco*carrinhoItem.Quantidade
                    }).ToList();
        }
    }
}
