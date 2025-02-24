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
            /* VendeTudo.com
             * 1. Material Escolar  
             * 2. Eletrodomesticos
             * 3. IA
             * 4. Material de Limpeza
             *  
             * Requisitos do programa:
             *  Criar um menu de compras, que voce pode comprar 2 item por categoria
             *  Deve conter pesquisadores, conversao, break, quebra de linha e fechar
             */
            ConsoleColor background = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     Seja bem vindo a loja Vende tudo         ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("     Desenvolvido por Otavio e Samuel 2DS     ");
            Console.ResetColor();
            Console.WriteLine("\n");

            object[] carrinho = new object[8];


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Compre algum produto da seção Material Escolar");
            Console.BackgroundColor = ConsoleColor.Blue;

            Product[] listaMaterial = MaterialEscolar();
            
            Console.WriteLine("             Escolha um produto               ");
            Console.ResetColor();

            int indexMaterial = 1;
            foreach (Product item in listaMaterial)
                {
                    Console.WriteLine($"Item {indexMaterial}:\n     Nome: {item.Nome},\n    Preço: R${item.Preco},\n    Descrição: {item.Descricao}.\n\n");
                    indexMaterial++;
                }
            for (int i = 0; i<2; i++)
            {
                /* escolher produto da seção Material Escolar */

            }

        }

        public static Product[] MaterialEscolar()
        {
            return new Product[]
            {
                new Product("Lapis", 1.5, "Lapis comum da Faber Castell"),
                new Product("Borracha", 2, "Borracha de tamanho médio que apaga coisas"),
                new Product("Caderno", 60, "Caderno de 20 matérias comum"),
                new Product("Fichario", 110, "Um fichario comum acompanhado de 100 folhas"),
                new Product("Mochila", 200, "Uma mochila de qualidade relativamente boaS")
            };
        }
    }
}