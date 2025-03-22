using chesnok.Application.Dtos;
using chesnok.Application.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chesnok.uz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemService _foodItemService;

        public FoodItemController(IFoodItemService foodItemService)
        {
            _foodItemService = foodItemService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFoodItemAsync([FromBody] CreateFoodItemDto foodItem)
        {
            await _foodItemService.CreateFoodItemAsync(foodItem);
            return Ok(foodItem);
        }


    }
}
