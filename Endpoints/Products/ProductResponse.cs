namespace IWanteApp.Endpoints.Products;

public record ProductResponse(string Name, string CategoryName, string Description, bool HasStock, decimal Price, bool Active);