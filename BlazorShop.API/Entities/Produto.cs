using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.API.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Nome { get; set; }
        [MaxLength(200)]
        public string? Descricao { get; set; }
        [MaxLength(200)]
        public string? ImagemUrl { get; set; }
        [Column(TypeName="decimal(10,2)")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public ICollection<CarrinhoItem>? Items { get; set; }
        public Produto()
        {
            Items = new Collection<CarrinhoItem>();
        }
    }
}
