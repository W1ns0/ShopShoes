namespace shopshoes_kuz;

public partial class OrderStatus
{
    public short Id { get; set; }

    public string OderStatus { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
