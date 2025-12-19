using System;
using System.Collections.Generic;

namespace shopshoes_kuz;

public partial class UnitOfMeasurement
{
    public short Id { get; set; }

    public string UnitOfMeasurement1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
