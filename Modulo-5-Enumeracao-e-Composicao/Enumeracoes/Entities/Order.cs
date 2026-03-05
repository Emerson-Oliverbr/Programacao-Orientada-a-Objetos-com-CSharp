using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities;

internal class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override String ToString()
    {
        return $"Id: {Id}, Momento:{Moment}, Status: {Status}";
    }
}
