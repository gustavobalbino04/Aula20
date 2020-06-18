using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gustavo = new Cliente("Gustavo","itaquera");
            System.Console.WriteLine(gustavo.Nome);
            System.Console.WriteLine(gustavo.EnderecoAtual);

            Restaurante mcdonalds = new Restaurante("mc donalds","Centro");
            System.Console.WriteLine(mcdonalds.NomeRestaurante);
            System.Console.WriteLine(mcdonalds.Endereco);
            
            Pedido pedido = new Pedido();
            pedido.Itens = "Lanches";
            pedido.Quantidade = 2;
            pedido.FormaDePGTO = "cartao";
            pedido.EntregarPedido();
            
        }
    }
}
