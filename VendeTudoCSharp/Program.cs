using System;

namespace Calculadora_Console
{
    public struct Product
    {
        public string Nome;
        public double Preco;
        public string Descricao;
        public Product(string nome, double preco, string descricao )
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor background = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     Seja bem-vindo à loja Vende Tudo         ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("     Desenvolvido por Otavio e Samuel 2DS     ");
            Console.ResetColor();
            Console.WriteLine("\n");

            Product[] carrinho = new Product[8];
            int carrinhoIndex = 0;

            // Seções de produtos
            carrinhoIndex = AdicionarProdutos("Material Escolar", MaterialEscolar(), carrinho, carrinhoIndex);
            carrinhoIndex = AdicionarProdutos("Eletrodomésticos", Eletrodomesticos(), carrinho, carrinhoIndex);
            carrinhoIndex = AdicionarProdutos("IA", IA(), carrinho, carrinhoIndex);
            carrinhoIndex = AdicionarProdutos("Material de Limpeza", MaterialLimpeza(), carrinho, carrinhoIndex);

            Console.WriteLine("\n\nResumo da sua compra:");
            double total = 0;
            foreach (Product item in carrinho)
            {
                if (!string.IsNullOrEmpty(item.Nome))
                {
                    Console.WriteLine($"{item.Nome} - R${item.Preco:F2}");
                    total += item.Preco;
                }
            }
            Console.WriteLine($"Total da compra: R${total:F2}\nObrigado por comprar conosco!");
        }

        static int AdicionarProdutos(string categoria, Product[] produtos, Product[] carrinho, int carrinhoIndex)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nCompre algum produto da seção {categoria}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("             Escolha até 2 produtos               ");
            Console.ResetColor();

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {produtos[i].Nome} - R${produtos[i].Preco:F2} ({produtos[i].Descricao})");
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Escolha o número do produto: ");
                if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= produtos.Length)
                {
                    carrinho[carrinhoIndex++] = produtos[escolha - 1];
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    i--;
                }
            }
            return carrinhoIndex;
        }

        public static Product[] MaterialEscolar() => new Product[]
        {
            new Product("Lápis", 1.5, "Lápis comum da Faber Castell"),
            new Product("Borracha", 2, "Borracha de tamanho médio que apaga coisas"),
            new Product("Caderno", 60, "Caderno de 20 matérias comum"),
            new Product("Fichário", 110, "Um fichário comum acompanhado de 100 folhas"),
            new Product("Mochila", 200, "Uma mochila de qualidade relativamente boa")
        };

        public static Product[] Eletrodomesticos() => new Product[]
        {
            new Product("Micro-ondas", 400, "Micro-ondas digital de 30L"),
            new Product("Geladeira", 2000, "Geladeira frost free 400L"),
            new Product("Liquidificador", 150, "Liquidificador potente 500W"),
            new Product("Aspirador", 300, "Aspirador de pó sem fio"),
            new Product("Fogão", 800, "Fogão 4 bocas com acendimento automático")
        };

        public static Product[] IA() => new Product[]
        {
            new Product("Assistente Virtual", 1000, "Assistente com IA para automação"),
            new Product("Chatbot", 500, "Chatbot para atendimento personalizado"),
            new Product("Detector de Fraude", 2000, "IA para segurança e detecção de fraudes"),
            new Product("Gerador de Imagens", 800, "Criação de imagens realistas com IA"),
            new Product("Otimizador de Processos", 1200, "IA que melhora a eficiência da empresa")
        };

        public static Product[] MaterialLimpeza() => new Product[]
        {
            new Product("Álcool", 15, "Álcool em gel 70%"),
            new Product("Desinfetante", 10, "Desinfetante com fragrância de lavanda"),
            new Product("Detergente", 5, "Detergente neutro para louças"),
            new Product("Esponja", 3, "Pacote com 4 esponjas multiuso"),
            new Product("Vassoura", 20, "Vassoura resistente para uso diário")
        };
    }
}
