using System;
namespace Aula20
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public int Quantidade { get; set; }
        public string Restaurante { get; set; }
        public string Cliente { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }


        public string EntregarPedido(){
           
           return $"O seu pedido ja está sendo encaminhado";

        }
        
    }
}