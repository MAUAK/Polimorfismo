using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    //Criando a classe produto
    class Produto
    {
        //Criando a variavel para o nome e fazendo o encapsulamento
        public string Nome { get; set; }
        //Criando a variavel para o preço e fazendo o encapsulamento
        public double Preco { get; set; }
        //Criando um construtor e colocando os valores certos nele
        public Produto (string nome, double preco)
        {
            //Igualando o valor da variavel nome do produto com a do construtor
            Nome = nome;
            //Igualando o valor da variavel preço do produto com a do construtor
            Preco = preco;
        }

        //public string precoTag();

        //Criando o método para escrever os valores do produto
        public virtual string etiquetaProduto()
        {
            return Nome + " - R$ " + Preco;
        }
    }
}
