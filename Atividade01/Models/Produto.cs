using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Atividade01.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
    }
}
