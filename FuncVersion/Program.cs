namespace LearnLambda
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var livros = GerarLivros(); 
            var livroRepository = new LivroRepository(livros);

            do
            {
                Console.Clear();
                MostrarMenu();
                var escolha = Utilities.LerNumeroInteiro("Digite o número da opção escolhida", 1, 5);

                switch (escolha)
                {
                    case 1:
                        livroRepository.Livros.ForEach(livro => Console.WriteLine(livro.ToString()));
                        break;
                    case 2:
                        var titulo = Utilities.LerString("Digite o título");
                        var livrosPorTitulo = livroRepository.Filtrar(livro => livro.Titulo.Contains(titulo, StringComparison.CurrentCultureIgnoreCase));
                        ImprimirLivros(livrosPorTitulo);
                        break;
                    case 3:
                        var anoPublicacao = Utilities.LerNumeroInteiro($"Digite o ano de publicação (1500 - {DateTime.Now.Year})", 1500, DateTime.Now.Year);
                        var livrosPorAno = livroRepository.Filtrar(livro => livro.AnoPublicacao == anoPublicacao);
                        ImprimirLivros(livrosPorAno);
                        break;
                    case 4:
                        var precoMax = Utilities.LerPreco("Digite o preço máximo", 1);
                        var livrosPorPreco = livroRepository.Filtrar(livro => livro.Preco <= precoMax);
                        ImprimirLivros(livrosPorPreco);
                        break;
                    case 5:
                        Console.WriteLine("Tchau!");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nPressione 'S' para fazer uma nova consulta ou qualquer outra tecla para sair");

            } while (Console.ReadLine().ToUpper().Equals("S"));

        }

        public static List<Livro> GerarLivros()
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
                new Livro { Titulo = "O Alcorão", Autor = "Vários", AnoPublicacao = 1609, Preco = 29.99m },
                new Livro { Titulo = "Xinhua Zidian", Autor = "Wei Jiangong", AnoPublicacao = 1957, Preco = 12.99m },
                new Livro { Titulo = "O Livro Vermelho", Autor = "Carl Jung", AnoPublicacao = 2009, Preco = 249.99m },
                new Livro { Titulo = "O Código Da Vinci", Autor = "Dan Brown", AnoPublicacao = 2003, Preco = 14.99m },
                new Livro { Titulo = "Crepúsculo", Autor = "Stephenie Meyer", AnoPublicacao = 2005, Preco = 19.99m }

            };
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("+            BIBLIOTECA VIRTUAL            +");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("+           Escolha uma opção:             +");
            Console.WriteLine("+      1 - Ver todos os livros             +");
            Console.WriteLine("+      2 - Filtrar por título              +");
            Console.WriteLine("+      3 - Filtrar por data de publicação  +");
            Console.WriteLine("+      4 - Filtrar por preço máximo        +");
            Console.WriteLine("+      5 - Sair                            +");
            Console.WriteLine("--------------------------------------------");
        }

        private static void ImprimirLivros(List<Livro> livros)
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado com base no filtro.");
            }
            else
            {
                livros.ForEach(livro => Console.WriteLine(livro.ToString()));
            }
        }

    }
}