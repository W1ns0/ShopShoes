namespace shopshoes_kuz;

public partial class Supplier
{
    public short Id { get; set; }

    public string Supplier1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
