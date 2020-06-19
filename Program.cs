using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gustavo = new Cliente("Gustavo","itaquera");
            Console.WriteLine(gustavo.MostrarDados());

            Restaurante mcdonalds = new Restaurante("mc donalds","Centro");
            Console.WriteLine(mcdonalds.MostrarDados());
            
            Pedido pedido = new Pedido();
            Console.WriteLine(pedido.EntregarPedido());
            
            
        }
    }
}
