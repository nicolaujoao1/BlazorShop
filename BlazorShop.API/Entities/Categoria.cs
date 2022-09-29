using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorShop.API.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Nome { get; set; }
        public string? IconCss { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
    }
}
