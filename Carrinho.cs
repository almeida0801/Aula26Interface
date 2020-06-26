using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(c => c.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(c => c.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                System.Console.WriteLine( $"{item.Nome} - R$ {item.Preco}");
            }
        }
        
        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

         public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Valor total da compra: R$ {ValorTotal}" );
            Console.ResetColor();


        }
    }
}