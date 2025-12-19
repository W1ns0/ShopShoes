using System;
using System.Collections.Generic;

namespace shopshoes_kuz;

public partial class Product
{
    public int Id { get; set; }

    public int IdProductName { get; set; }

    public decimal Price { get; set; }

    public short IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public int IdProductCategory { get; set; }

    public int? CurrentDiscount { get; set; }

    public int QuantityInStock { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public string Article { get; set; } = null!;

    public short IdUnitOfMeasurement { get; set; }

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual ProductCategory IdProductCategoryNavigation { get; set; } = null!;

    public virtual ProductName IdProductNameNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitOfMeasurement IdUnitOfMeasurementNavigation { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}
