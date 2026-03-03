using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order 
            { Id = 1080,
              Moment = DateTime.Now,
              Status = OrderStatus.PagamentoPendente
            };
        Console.WriteLine($"Status do pedido: {order}");

        //Conversões

        string txt = OrderStatus.PagamentoPendente.ToString();
        Console.WriteLine(txt);

        OrderStatus os = Enum.Parse<OrderStatus>("Entregue");
        Console.WriteLine(os);

        Console.ReadKey();
    }
}