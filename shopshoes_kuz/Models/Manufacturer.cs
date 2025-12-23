namespace shopshoes_kuz;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string Manufacture { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
