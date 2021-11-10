using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista de prodtuos
            List<Produto> list = new List<Produto>();
            //Pedindo e lendo o número de produtos que irão existir
            Console.WriteLine("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //Criando uma estrutura de retição para colocar os valores dos produtos
            for (int i = 1; i <= n; i++)
            {
                //Imprimindo a posição do produto que receberá os valores
                Console.WriteLine($"Produto #{i}: ");
                //Perguntado se é um produto importado, comum ou usado 
                Console.Write("Comum, Usado ou Importado (C/U/I)? ");
                //Guardando na variável
                char ch = char.Parse(Console.ReadLine());
                //Perguntado o nome do protudo
                Console.Write("Nome: ");
                //Guardando na variável
                string nome = Console.ReadLine();
                //Perguntado o preço do protudo
                Console.Write("Preço: ");
                //Guardando na variável
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Veificando se é importado
                if (ch == 'I')
                {
                    //Pedindo a taxa do produto e guardando ela em uma variavel
                    Console.Write("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Colocando o valor total com o calculo da taxa em uma variavel
                    double valortotaltaxa = preco + (preco * (taxa/100));
                    //Adicionando na lista esta forma com seus valores
                    list.Add(new ProdutoImportado(nome, preco, taxa, valortotaltaxa));
                }
                //Veificando se é comum
                else if (ch == 'C')
                {
                    //Adicionando na lista esta forma com seus valores
                    list.Add(new Produto(nome, preco));
                }
                //Veificando se é usado
                else if (ch == 'U')
                {
                    //Pedindo a data de fabricação  do produto e guardando ela em uma variável
                    Console.Write("Fabricado (DD/MM/AA): ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Adicionando na lista esta forma com seus valores
                    list.Add(new ProdutoUsado(nome, preco, fabricacao));
                }
                //Pulando linha
                Console.WriteLine();
            }
            //Escrevendo cada protudo com suas informações
            Console.WriteLine("Cada produto: ");
            //Para cada produto da lista
            foreach (Produto produto in list)
            {
                //Imprimindo informações!
                Console.WriteLine(produto.etiquetaProduto());
            }
        }
    }
}
