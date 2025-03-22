using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chesnok.Domain.Entities
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
    }
    public enum FoodCategory
    {
        Vegetables,
        Fruits,
        Meat,
        Dairy,
        Grains,
        Snacks,
        Beverages
    }
}
