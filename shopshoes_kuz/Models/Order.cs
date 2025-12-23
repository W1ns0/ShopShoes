namespace shopshoes_kuz;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly DateOfOrder { get; set; }

    public DateOnly? DateOfDelivery { get; set; }

    public int IdAddressOfDeliveryPoint { get; set; }

    public int IdUser { get; set; }

    public short CodeToReceive { get; set; }

    public short IdOrderStatus { get; set; }

    public virtual AddressesOfDeliveryPoint AddressesOfDeliveryPoint { get; set; } = null!;

    public virtual OrderStatus OrderStatus { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}
