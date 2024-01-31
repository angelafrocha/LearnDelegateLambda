using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLambda
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }

        public override string? ToString()
        {
            return $"TÍTULO: {Titulo, -40} | R${Preco, -10:F2} | PUBLICADO EM: {AnoPublicacao}";
        }
    }

    

}
