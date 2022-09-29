﻿using System.Collections.ObjectModel;
namespace BlazorShop.Models.Entities;
public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public ICollection<CarrinhoItem>? Items { get; set; }
    public Carrinho()
    {
        Items = new Collection<CarrinhoItem>();
    }
}
