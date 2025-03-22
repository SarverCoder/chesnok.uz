using chesnok.Domain.Entities;

namespace chesnok.Application.Dtos;

public class FoodItemDto
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public FoodCategory FoodCategory { get; set; }
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public double Fats { get; set; }
}

public class CreateFoodItemDto
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public FoodCategory FoodCategory { get; set; }
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public double Fats { get; set; }

    public FoodItem ToEntity()
    {
        return new FoodItem
        {
            Name = Name,
            Calories = Calories,
            FoodCategory = FoodCategory,
            Protein = Protein,
            Carbs = Carbs,
            Fats = Fats
        };
    }
}
