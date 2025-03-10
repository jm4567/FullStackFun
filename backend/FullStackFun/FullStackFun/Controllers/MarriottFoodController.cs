using FullStackFun.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FullStackFun.Controllers;

[Route("api/[controller]")]
[ApiController]

public class MarriottFoodController : ControllerBase
{
    //constructor
    private FoodDbContext _foodContext;

    public MarriottFoodController(FoodDbContext temp)
    {
        _foodContext = temp;
    }

    [HttpGet(Name = "GetMarriottFood")]
    public IEnumerable<MarriottFood> Get()
    {
        var foodList = _foodContext.Foods.ToList();
        return (foodList);//dont do stuff in return statement. just want to hand it stuff 
    }
}
