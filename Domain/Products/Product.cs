namespace IWanteApp.Domain.Products;

public class Product : Entity
{
    public string Name { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
}