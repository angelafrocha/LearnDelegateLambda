﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LearnLambda.Program;

namespace LearnLambda
{
    public class LivroRepository
    {
        public List<Livro> Livros { get; }

        public LivroRepository(List<Livro> livros) => this.Livros = livros;

        public List<Livro> Filtrar(Filter<Livro> filtro)
        {
            return Livros.Where(x => filtro(x)).ToList();
        }
    }

   
}
