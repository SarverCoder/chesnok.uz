
using chesnok.Application.Repository.Interfaces;
using chesnok.DataAccess;
using chesnok.Domain.Entities;

namespace chesnok.Application.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
