﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Carrinho?   Carrinho { get; set; }
    }
}
