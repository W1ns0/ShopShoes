using Microsoft.EntityFrameworkCore;

namespace shopshoes_kuz;

public partial class DeShopShoesKuzContext : DbContext
{
    public DeShopShoesKuzContext()
    {
    }

    public DeShopShoesKuzContext(DbContextOptions<DeShopShoesKuzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressesOfDeliveryPoint> AddressesOfDeliveryPoints { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductName> ProductNames { get; set; }

    public virtual DbSet<ProductsOrder> ProductsOrders { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DE_Shop_Shoes_kuz;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressesOfDeliveryPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addresses_of_delivery_points_pkey");

            entity.ToTable("addresses_of_delivery_points");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.House).HasColumnName("house");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Manufacture).HasColumnName("manufacture");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeToReceive).HasColumnName("code_to_receive");
            entity.Property(e => e.DateOfDelivery).HasColumnName("date_of_delivery");
            entity.Property(e => e.DateOfOrder).HasColumnName("date_of_order");
            entity.Property(e => e.IdAddressOfDeliveryPoint).HasColumnName("id_address_of_delivery_point");
            entity.Property(e => e.IdOrderStatus).HasColumnName("id_order_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.AddressesOfDeliveryPoint).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdAddressOfDeliveryPoint)
                .HasConstraintName("fk_orders_to_addresses_of_delivery_points");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdOrderStatus)
                .HasConstraintName("fk_orders_to_order_statuses");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_orders_to_users");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_statuses_pkey");

            entity.ToTable("order_statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OderStatus).HasColumnName("oder_status");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.CurrentDiscount).HasColumnName("current_discount");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdProductCategory).HasColumnName("id_product_category");
            entity.Property(e => e.IdProductName).HasColumnName("id_product_name");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdUnitOfMeasurement).HasColumnName("id_unit_of_measurement");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.QuantityInStock).HasColumnName("quantity_in_stock");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .HasConstraintName("fk_products_to_manufacturers");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductCategory)
                .HasConstraintName("fk_products_to_product_categories");

            entity.HasOne(d => d.ProductName).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductName)
                .HasConstraintName("fk_products_to_product_names");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("fk_products_to_suppliers");

            entity.HasOne(d => d.UnitOfMeasurement).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdUnitOfMeasurement)
                .HasConstraintName("fk_products_to_unit_of_measurements");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("croduct_categories_pkey");

            entity.ToTable("product_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProductCategory1).HasColumnName("product_category");
        });

        modelBuilder.Entity<ProductName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_names_pkey");

            entity.ToTable("product_names");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProducteName).HasColumnName("producte_name");
        });

        modelBuilder.Entity<ProductsOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_orders_pkey");

            entity.ToTable("products_orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.Order).WithMany(p => p.ProductsOrders)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("fk_products_orders_to_orders");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsOrders)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("fk_products_orders_to_products");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Role1).HasColumnName("role");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Supplier1).HasColumnName("supplier");
        });

        modelBuilder.Entity<UnitOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("unit_of_measurements_pkey");

            entity.ToTable("unit_of_measurements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UnitOfMeasurement1).HasColumnName("unit_of_measurement");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
