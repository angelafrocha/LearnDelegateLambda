using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LearnLambda.Program;

namespace LearnLambda
{
    internal class LivroRepository
    {
        public List<Livro> livros { get; }

        public LivroRepository(List<Livro> livros) => this.livros = livros;

        public List<Livro> Filtrar(Filter<Livro> filtro)
        {
            return livros.Where(x => filtro(x)).ToList();
        }
    }

   
}
