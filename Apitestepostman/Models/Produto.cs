using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apitestepostman.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Preco { get; set; }
        public Categoria Categoria { get; set; }
     
   
    }
}
