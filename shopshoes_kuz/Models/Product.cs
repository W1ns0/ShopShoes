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

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ProductCategory ProductCategory { get; set; } = null!;

    public virtual ProductName ProductName { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual UnitOfMeasurement UnitOfMeasurement { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}
