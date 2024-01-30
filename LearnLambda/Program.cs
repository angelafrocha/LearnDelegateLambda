namespace LearnLambda
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var livros = DataLivro(); var livroRepository = new LivroRepository(livros);

            int sair = 0;
            while (sair == 0)
            {
                int op;

                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1-Ver todos os livros");
                Console.WriteLine("2-Filtrar por título");
                Console.WriteLine("3-Filtrar por data de publicação");
                Console.WriteLine("4-Filtrar por preço");
                Console.WriteLine("5 - sair");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            VerListaDeLivros(livroRepository.livros);
                            break;
                        case 2:
                            Console.WriteLine("Digite o titulo:");
                            string titulo = Console.ReadLine();
                            VerListaDeLivros(livroRepository.Filtrar(LivroFilter.FiltrarPorTitulo(titulo)));
                            break;
                        case 3:
                            Console.WriteLine("Digite a data de publicação:");
                            if (int.TryParse(Console.ReadLine(), out int ano) && ano > 1500)
                            {
                                VerListaDeLivros(livroRepository.Filtrar(LivroFilter.FiltrarAnoPublicacao(ano)));
                            }
                            else
                                Console.WriteLine("Ano inválido :/");
                            break;
                        case 4:
                            Console.WriteLine("Digite o preço:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal preco) && preco > 0)
                            {
                                VerListaDeLivros(livroRepository.Filtrar(LivroFilter.filtrarPorPreco(preco)));
                            }
                            else
                                Console.WriteLine("Preço inválido :/");
                            break;
                        case 5:
                            Console.WriteLine("Tchau!");
                            sair = 1;
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida :/");
                }
                Console.ReadKey();
                Console.Clear();
            }


        }

        public static List<Livro> DataLivro()
        {
            return new List<Livro>
            {
                new Livro { Titulo = "Café com Deus Pai 2024", Autor = "Júnior Rostirola", AnoPublicacao = 2024, Preco = 83.66m },
                new Livro { Titulo = "Perigoso!", Autor = "Tim Warnes", AnoPublicacao = 2023, Preco = 9.90m },
                new Livro { Titulo = "A Biblioteca da Meia-Noite", Autor = "Matt Haig", AnoPublicacao = 2023, Preco = 41.10m },
                new Livro { Titulo = "O homem mais rico da Babilônia", Autor = "Luiz Cavalcanti de M. Guerra",AnoPublicacao = 2023, Preco = 17.99m },
                new Livro { Titulo = "Maus", Autor = "Art Spiegelman", AnoPublicacao = 2023, Preco = 40.50m },
                new Livro { Titulo = "Hábitos atômicos", Autor = "James Clear", AnoPublicacao = 2023, Preco = 44.00m },
                new Livro { Titulo = "Os segredos da mente milionária", Autor = "T. Harv Eker", AnoPublicacao = 2023, Preco = 19.85m },
                new Livro { Titulo = "A revolução dos bichos", Autor = "George Orwell", AnoPublicacao = 2023, Preco = 8.00m },
                new Livro { Titulo = "Tudo é rio", Autor = "Carla Madeira", AnoPublicacao = 2023, Preco = 30.00m },
                new Livro { Titulo = "A psicologia financeira", Autor = "Morgan Housel", AnoPublicacao = 2023, Preco = 31.00m },
                new Livro { Titulo = "A Bíblia", Autor = "Vários", AnoPublicacao = 1454, Preco = 99.99m },
                new Livro { Titulo = "Citações do Presidente Mao Tse-Tung", Autor = "Mao Tse-Tung", AnoPublicacao = 1964, Preco = 15.99m },
                new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", AnoPublicacao = 1997, Preco = 20.99m },
                new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", AnoPublicacao = 1954, Preco = 25.99m },
                new Livro { Titulo = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry", AnoPublicacao = 1943, Preco = 10.99m },
                new Livro { Titulo = "O Alcorão", Autor = "Vários", AnoPublicacao = 609, Preco = 29.99m },
                new Livro { Titulo = "Xinhua Zidian", Autor = "Wei Jiangong", AnoPublicacao = 1957, Preco = 12.99m },
                new Livro { Titulo = "O Livro Vermelho", Autor = "Carl Jung", AnoPublicacao = 2009, Preco = 249.99m },
                new Livro { Titulo = "O Código Da Vinci", Autor = "Dan Brown", AnoPublicacao = 2003, Preco = 14.99m },
                new Livro { Titulo = "Crepúsculo", Autor = "Stephenie Meyer", AnoPublicacao = 2005, Preco = 19.99m }

            };
        }
        public static void VerListaDeLivros(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                Console.WriteLine($"{livro.Titulo} | R${livro.Preco} | Publicado em {livro.AnoPublicacao}");
            }
        }
    }
}