namespace shopshoes_kuz;

public partial class AddressesOfDeliveryPoint
{
    public int Id { get; set; }

    public int Index { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public short House { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
