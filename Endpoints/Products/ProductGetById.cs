using IWanteApp.Infra.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IWanteApp.Endpoints.Products;

public class ProductGetById
{
    public static string Template => "/products/{id}";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    [AllowAnonymous]
    public static async Task<IResult> Action([FromRoute] Guid id, ApplicationDbContext context)
    {
        var product = context.Products.Include(p => p.Category).Where(p => p.Id == id).OrderBy(p => p.Name).Where(p => p.Id == id);

        var result = product.Select(p => new ProductResponse(p.Name, p.Category.Name, p.Description, p.HasStock, p.Price, p.Active));

        if (result != null)
        {
            return Results.Ok(result);
        }
        return Results.NotFound();
    }
}