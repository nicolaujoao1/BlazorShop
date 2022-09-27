using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descricao { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
