using System.Security.Claims;
using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;

namespace IWanteApp.Endpoints.Employees;

public class EmployeeGetAll
{
    public static string Template => "/employees";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(int? page, int? rows, IConfiguration configuration)
    {
        var db = new SqlConnection(configuration["ConnectionString:IWantDb"]);

        var employees = db.Query<EmployeeResponse>(
            @"select Email, ClaimValue as Name
            from AspNetUsers u inner join AspNetUserClaims c
o           on u.id = c.UserId and claimtype = 'Name'"
        );
        return Results.Ok(employees);
    }
}