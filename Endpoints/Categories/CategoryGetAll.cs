using IWanteApp.Domain.Products;
using IWanteApp.Infra.Data;
using Microsoft.AspNetCore.Authorization;

namespace IWanteApp.Endpoints.Categories;

public class CategoryGetAll
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    [AllowAnonymous]
    public static IResult Action (ApplicationDbContext context)
    {

        //retorna nossa lista de categorias, o response e não a entidade
        var categories = context.Categories.ToList();
        var responde = categories.Select(c => new CategoryResponse { Id = c.Id, Name = c.Name, Active = c.Active});
        return Results.Ok(responde);
    }

}