using System;


namespace Aula26Interface
{
    class Program
    {
        static void Main(string[] args)
        {
          Carrinho carrinhodecompras = new Carrinho();

            Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("--Carrinho dos Games--");
                System.Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Cyan;
          Produto p1 = new Produto(1,"Rocket League", 45.90f );
          Produto p2 = new Produto(2,"Fifa 21", 300.90f );
          Produto p3 = new Produto(3,"The Last Of US 2", 250.90f );
          Produto p4 = new Produto(4,"Red dead Redemption 2", 149.90f);
          
         

          carrinhodecompras.Adicionar(p1);
          carrinhodecompras.Adicionar(p2);
          carrinhodecompras.Adicionar(p3);
          carrinhodecompras.Adicionar(p4);

            carrinhodecompras.Remover(p4);

            Produto prodAlterado = new Produto (1, "God of War IV", 180.90f);
            carrinhodecompras.Alterar(1, prodAlterado);

            carrinhodecompras.Ler();
            System.Console.WriteLine("");
            carrinhodecompras.MostrarTotal();


        }
    }
}