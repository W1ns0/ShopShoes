namespace shopshoes_kuz;

public partial class ProductName
{
    public int Id { get; set; }

    public string ProducteName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
