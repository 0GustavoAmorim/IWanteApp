namespace IWanteApp.Endpoints.Orders;

public record OrderRequest(List<Guid> ProductsId, string DeliveryAddress);
