using System;
using System.Collections.Generic;

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

    public virtual AddressesOfDeliveryPoint IdAddressOfDeliveryPointNavigation { get; set; } = null!;

    public virtual OrderStatus IdOrderStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}
