using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLambda
{
    public static class LivroFilter
    {

        public static Filter<Livro> FiltrarPorTitulo(string titulo)
        {
            return (livro) => livro.Titulo.Contains(titulo);
        }

        public static  Filter<Livro> FiltrarPrecoMax(decimal preco)
        {
            return (livro) => livro.Preco <= preco;
        }
        public static Filter<Livro> FiltrarAnoPublicacao(int AnoPublicacao)
        {
            return (livro) => livro.AnoPublicacao >= AnoPublicacao;
        }

    }
}
