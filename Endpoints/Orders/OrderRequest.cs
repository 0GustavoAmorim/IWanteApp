namespace IWanteApp.Endpoints.Orders;

public record OrderRequest(List<Guid> ProductIds, string deliveryAddress);