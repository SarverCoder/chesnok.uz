

using chesnok.Application.Dtos;
using chesnok.Application.Repository.Interfaces;

namespace chesnok.Application.Service;

public interface IFoodItemService
{
    Task CreateFoodItemAsync(CreateFoodItemDto foodItem);
}
public class FoodItemService : IFoodItemService
{
    private readonly IFoodItemRepository _foodItemRepository;

    public FoodItemService(IFoodItemRepository foodItemRepository)
    {
        _foodItemRepository = foodItemRepository;
    }

    public async Task CreateFoodItemAsync(CreateFoodItemDto foodItem)
    {
            var food = foodItem.ToEntity();

            await _foodItemRepository.AddAsync(food);
            await _foodItemRepository.SaveChangesAsync();
    }
}
