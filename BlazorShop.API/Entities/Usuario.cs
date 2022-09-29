using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? NomeUsuario { get; set; }
        public Carrinho?   Carrinho { get; set; }
    }
}
