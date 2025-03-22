
using chesnok.Application.Repository.Interfaces;
using chesnok.DataAccess;
using chesnok.Domain.Entities;

namespace chesnok.Application.Repository
{
    public class FoodItemRepository : Repository<FoodItem>, IFoodItemRepository
    {
        public FoodItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
