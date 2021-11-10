using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    //criando uma subclasse do Produto
    class ProdutoImportado : Produto
    {
        //Criando a variavel para a taxa e fazendo o encapsulamento
        public double Taxa { get; set; }
        //Criando a variavel para a taxa e fazendo o encapsulamento
        public double ValorTotalTaxa { get; set; }

        //Criando um construtor e colocando os valores certos nele
        public ProdutoImportado(string nome, double preco, double taxa, double valortotaltaxa) : base (nome, preco)
        {
            //Igualando os valores das variaveies do produto com a do construtor
            Nome = nome;
            Preco = preco;
            Taxa = taxa;
            ValorTotalTaxa = valortotaltaxa;
        }

        /*public void precoTotal()
        {
            //Fazendo o calculo
            Preco = Preco + Taxa;
        }*/

        //Criando o método para reescrever os valores do produto importado
        public override string etiquetaProduto()
        {
            return Nome + " - R$ " + Preco + " (Taxa: " + Taxa + ")" + " - Valor total com a taxa = R$ " + ValorTotalTaxa;
        }
    }
}
