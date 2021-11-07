using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    //criando uma subclasse do Produto
    class ProdutoUsado : Produto
    {
        //Criando a variavel para a fabricação e fazendo o encapsulamento
        public DateTime Fabricacao { get; set; }

        //Criando um construtor e colocando os valores certos nele
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            //Igualando os valores das variaveies do produto com a do construtor
            Nome = nome;
            Preco = preco;
            Fabricacao = fabricacao;
        }

        //Criando o método para reescrever os valores do produto importado
        public override string etiquetaProduto()
        {
            return Nome + " (usado) - R$ " + Preco + " (fabricado em: " + Fabricacao + ")";
        }
    }
}
