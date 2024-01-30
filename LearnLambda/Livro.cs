using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLambda
{
    public class Livro
    {
       

        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }
    }

    

}
